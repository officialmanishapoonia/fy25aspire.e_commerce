using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fy25aspire.e_commerce.Server.Data.Models
{
    public class CartItemDTO
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("cart")]
        public string CartId { get; set; }
        public CartDTO cart { get; set; }

        [ForeignKey("product")]
        public string ProductId { get; set; }
        public ProductDTO product { get; set; }

        public double Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

    }
}
