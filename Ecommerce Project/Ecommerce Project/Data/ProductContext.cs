using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Project.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {

        }
    }
}
