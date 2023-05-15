using System.ComponentModel.DataAnnotations;

namespace E_Library.Models
{
    public class Genre
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }
        public ICollection<BookGenre> Books { get; set; }
    }
}
