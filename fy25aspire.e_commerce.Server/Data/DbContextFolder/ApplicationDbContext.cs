

//using Microsoft.EntityFrameworkCore;
//using fy25aspire.e_commerce.Server.Data.Models;

//namespace fy25aspire.e_commerce.Server.Data
//{
//    public class ApplicationDbContext : DbContext
//    {
//        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<UserDTO> Users { get; set; }
//        public DbSet<ProductDTO> Products { get; set; }
//        public DbSet<OrderDTO> Orders { get; set; }
//        public DbSet<OrderItemDTO> OrderItems { get; set; }
//        public DbSet<CartDTO> Carts { get; set; }
//        public DbSet<CartItemDTO> CartItems { get; set; }
//        public DbSet<AddressDTO> Addresses { get; set; }


//    }
//}

using Microsoft.EntityFrameworkCore;
using fy25aspire.e_commerce.Server.Data.Models;
using System;

namespace fy25aspire.e_commerce.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserDTO> Users { get; set; }
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<OrderDTO> Orders { get; set; }
        public DbSet<OrderItemDTO> OrderItems { get; set; }
        public DbSet<CartDTO> Carts { get; set; }
        public DbSet<CartItemDTO> CartItems { get; set; }
        public DbSet<AddressDTO> Addresses { get; set; }
        public DbSet<ReviewDTO> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Sample data for UserDTO
            modelBuilder.Entity<UserDTO>().HasData(
                new UserDTO
                {
                    Id = "1",
                    Email = "user1@example.com",
                    UserName = "user1",
                    Password = "password1",
                    Role = "Customer",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );

            // Sample data for ProductDTO
            modelBuilder.Entity<ProductDTO>().HasData(
                new ProductDTO
                {
                    Id = "1",
                    Name = "Sample Product",
                    UserId = "1",
                    Description = "This is a sample product.",
                    Category = "Electronics",
                    Price = 99.99,
                    ImageUrl = "http://example.com/product.jpg",
                    StockQuantity = 100,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "user1",
                    UpdatedBy = "user1"
                }
            );

            // Sample data for OrderDTO
            modelBuilder.Entity<OrderDTO>().HasData(
                new OrderDTO
                {
                    Id = "1",
                    UserId = "1",
                    OrderStatus = "Pending",
                    TotalAmount = 199,
                    PaymentStatus = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "user1",
                    UpdatedBy = "user1"
                }
            );

            // Sample data for OrderItemDTO
            modelBuilder.Entity<OrderItemDTO>().HasData(
                new OrderItemDTO
                {
                    Id = "1",
                    OrderId = "1",
                    ProductId = "1",
                    quantity = 2,
                    createdAt = DateTime.Now,
                    updatedAt = DateTime.Now,
                    CreatedBy = "user1",
                    UpdatedBy = "user1"
                }
            );

            // Sample data for CartDTO
            modelBuilder.Entity<CartDTO>().HasData(
                new CartDTO
                {
                    Id = "1",
                    UserId = "1",
                    TotalQuantity = 2,
                    TotalAmount = 199
                }
            );

            // Sample data for CartItemDTO
            modelBuilder.Entity<CartItemDTO>().HasData(
                new CartItemDTO
                {
                    Id = "1",
                    CartId = "1",
                    ProductId = "1",
                    Quantity = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "user1",
                    UpdatedBy = "user1"
                }
            );

            // Sample data for AddressDTO
            modelBuilder.Entity<AddressDTO>().HasData(
                new AddressDTO
                {
                    Id = "1",
                    UserId = "1",
                    AddressType = "Home",
                    Address = "123 Main St",
                    City = "Anytown",
                    State = "Anystate",
                    Country = "USA",
                    ZipCode = "12345",
                    Phone = "123-456-7890",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );

            // Sample data for ReviewDTO
            modelBuilder.Entity<ReviewDTO>().HasData(
                new ReviewDTO
                {
                    Id = "1",
                    ProductId = "1",
                    UserId = "1",
                    Review = "Great product!",
                    Rating = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );

            modelBuilder.Entity<CartDTO>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.user)
                    .WithMany()
                    .HasForeignKey(c => c.UserId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<CartItemDTO>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.cart)
                    .WithMany()
                    .HasForeignKey(c => c.CartId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(c => c.product)
                    .WithMany()
                    .HasForeignKey(c => c.ProductId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<OrderDTO>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.user)
                    .WithMany()
                    .HasForeignKey(c => c.UserId)
                    .OnDelete(DeleteBehavior.NoAction);

            });
            modelBuilder.Entity<OrderItemDTO>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.order)
                    .WithMany()
                    .HasForeignKey(c => c.OrderId)
                    .OnDelete(DeleteBehavior.NoAction);


                entity.HasOne(c => c.product)
                    .WithMany()
                    .HasForeignKey(c => c.ProductId)
                    .OnDelete(DeleteBehavior.NoAction);

            });
            modelBuilder.Entity<AddressDTO>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.user)
                    .WithMany()
                    .HasForeignKey(c => c.UserId)
                    .OnDelete(DeleteBehavior.NoAction);


               

            });
            modelBuilder.Entity<ReviewDTO>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.user)
                    .WithMany()
                    .HasForeignKey(c => c.UserId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(c => c.product)
                  .WithMany()
                  .HasForeignKey(c => c.ProductId)
                  .OnDelete(DeleteBehavior.NoAction);


            });


            //    modelBuilder.Entity<CartItemDTO>()
            //.HasOne(d => d.cart)
            //.WithMany(p => p.CartItemDTO)
            //.HasForeignKey(d => d.PrincipalEntityId)
            //.OnDelete(DeleteBehavior.Restrict);

        }
    }
}

