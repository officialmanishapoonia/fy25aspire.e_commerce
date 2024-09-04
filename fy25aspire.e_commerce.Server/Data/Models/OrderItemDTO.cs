using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fy25aspire.e_commerce.Server.Data.Models
{
    public class OrderItemDTO
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("order")]
        public string OrderId { get; set; }
        public OrderDTO order { get; set; }
        [ForeignKey("product")]
        public string ProductId { get; set; }
        public ProductDTO product { get; set; }
        public int quantity { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }



    }
}
