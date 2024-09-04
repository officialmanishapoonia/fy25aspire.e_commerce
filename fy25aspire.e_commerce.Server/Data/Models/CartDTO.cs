using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fy25aspire.e_commerce.Server.Data.Models
{
    public class CartDTO
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("user")]
        public string UserId { get; set; }
        public UserDTO user { get; set; }
        public double TotalQuantity { get; set; }
        public double TotalAmount { get; set; }


    }
}
