using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebBookApp.Models;

namespace WebBookApp.Data
{
    public class WebBookAppContext : DbContext
    {
        public WebBookAppContext (DbContextOptions<WebBookAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebBookApp.Models.Book> Book { get; set; } = default!;
        public DbSet<WebBookApp.Models.Customer> Customer { get; set; } = default!;
        public DbSet<WebBookApp.Models.Sale> Sale { get; set; } = default!;
    }
}
