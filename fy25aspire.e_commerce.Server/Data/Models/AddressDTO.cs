using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fy25aspire.e_commerce.Server.Data.Models
{
    public class AddressDTO
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("user")]
        public string UserId { get; set; }
        public UserDTO user { get; set; }
        public string AddressType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
