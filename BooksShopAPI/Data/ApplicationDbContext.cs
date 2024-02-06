using BooksShopAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace BooksShopAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Bullying> Bullyings { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<BuyerBook> BuyerBooks { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

    }
}

