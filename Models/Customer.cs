using System.ComponentModel.DataAnnotations;
namespace WebBookApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string? CustomerName { get; set; }

        [EmailAddress]
        public string? CustomerEmail { get; set;}
    }
}
