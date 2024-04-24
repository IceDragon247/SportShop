using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportShop.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string? ProductName { get; set; }
        [Required]
        [MaxLength(40)]
        public string? ProducerName { get; set; }
        [MaxLength(10)]
        public string? Size { get; set; }
        [MaxLength(255)]
        public string? Description { get; set; }
        [MaxLength(50)]
        public string? Brand { get; set; }
        [MaxLength(50)]
        public string? Branch { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { set; get; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<OrderDetail> OrderDetail { get; set;}
        public List<CartDetail> CartDetail { get; set; }

        [NotMapped]
        public string CategoryName { get; set; }
    }
}
