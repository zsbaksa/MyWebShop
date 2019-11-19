using System.ComponentModel.DataAnnotations;

namespace MyWebShop.Web.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(21)]
        public string Name { get; set; }

        [Range(1, 1000000)]
        public decimal Price { get; set; }

        [RegularExpression("[a-zA-Z0-9]")]
        public string Description { get; set; }
        public string Category { get; set; }
    }
}