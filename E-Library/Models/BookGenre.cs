using System.ComponentModel.DataAnnotations;

namespace E_Library.Models
{
    public class BookGenre
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }
        [Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
