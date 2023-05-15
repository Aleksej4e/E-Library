using System.ComponentModel.DataAnnotations;

namespace E_Library.Models
{
    public class Author
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public DateTime? BirthDate { get; set; }
        [StringLength(50)]
        public string? Nationality { get; set; }
        [StringLength(50)]
        public string? Gender { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
