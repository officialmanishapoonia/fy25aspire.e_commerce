using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fy25aspire.e_commerce.Server.Data.Models
{
    public class OrderDTO
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("user")]
        public string UserId { get; set; }
        public UserDTO user { get; set; }

        public string OrderStatus { get; set; }
        public int TotalAmount { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }




    }
}
