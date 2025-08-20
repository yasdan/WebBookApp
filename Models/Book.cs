using System.ComponentModel.DataAnnotations;
namespace WebBookApp.Models
{
    public class Book
    {
        [Key]
        public int BookId {  get; set; }
        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Genre { get; set; }

        public double Price {  get; set; }

        [Required]
        public string? Author { get; set; }




    }
}
