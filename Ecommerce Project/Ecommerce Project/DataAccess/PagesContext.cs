using Ecommerce_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Project.DataAccess
{
    public class PagesContext : DbContext
    {
        public PagesContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Page> Pages { get; set; }

        public PagesContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-890Q20G; Initial Catalog=EcommerceStore; Integrated Security = True;");
        }
    }
}
