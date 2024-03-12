using System.ComponentModel.DataAnnotations;
namespace WebBookApp.Models
{
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int BookId { get; set; }

        public int CustomerId { get; set; }

        public virtual Book? Book { get; set; }
        public virtual Customer? Customer { get; set; }



    }
}
