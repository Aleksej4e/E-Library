using System.ComponentModel.DataAnnotations;

namespace E_Library.Models
{
    public class UserBook
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(450)]
        public string AppUser { get; set; }
        [Required]
        public int BookId { get; set; }
    }
}
