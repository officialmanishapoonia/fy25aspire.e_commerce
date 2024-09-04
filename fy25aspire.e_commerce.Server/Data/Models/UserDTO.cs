using System.ComponentModel.DataAnnotations;

namespace fy25aspire.e_commerce.Server.Data.Models
{
    public class UserDTO
    {
        [Key]
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
