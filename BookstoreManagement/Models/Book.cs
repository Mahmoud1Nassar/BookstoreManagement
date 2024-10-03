using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Range(1, 1000)]
        public decimal Price { get; set; }

        [StringLength(50)]
        public string Genre { get; set; }
    }
}
