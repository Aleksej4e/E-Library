using System.ComponentModel.DataAnnotations;

namespace E_Library.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public int? YearPublished { get; set; }
        public int? NumPages { get; set; }
        public string? Description { get; set; }
        [StringLength(50)]
        public string? Publisher { get; set; }
        public string? FrontPage { get; set; }
        public string? DownloadURL { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<BookGenre> Genres { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<UserBook> Users { get; set; }
    }
}
