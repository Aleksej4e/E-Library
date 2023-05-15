using System.ComponentModel.DataAnnotations;

namespace E_Library.Models
{
    public class Review
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [StringLength(450)]
        public string AppUser { get; set; }
        [StringLength(500)]
        public string Comment { get; set; }
        public int? Rating { get; set; }
    }
}
