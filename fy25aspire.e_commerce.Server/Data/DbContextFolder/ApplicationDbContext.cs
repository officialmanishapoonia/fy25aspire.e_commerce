using fy25aspire.e_commerce.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace fy25aspire.e_commerce.Server.Data.DbContextFolder
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } //here we are passing the options to the base class where in the startup.cs we are passing the connection string

        public DbSet<UserDTO> User { get; set; } // this is the table name in the database
    }
}
