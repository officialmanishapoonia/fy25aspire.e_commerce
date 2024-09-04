using System.ComponentModel.DataAnnotations.Schema;

namespace fy25aspire.e_commerce.Server.Data.Models
{
    public class ReviewDTO
    {
        public string Id { get; set; }

        [ForeignKey("product")]
        public string ProductId { get; set; }
        public ProductDTO product { get; set; }
        [ForeignKey("user")]
        public string UserId { get; set; }
        public UserDTO user { get; set; }

        public string Review { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
