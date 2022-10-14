using Ecommerce_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Project.DataAccess
{
    public class PagesContext : DbContext 
    {
        public PagesContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Page> Pages { get; set; }
    }
}
