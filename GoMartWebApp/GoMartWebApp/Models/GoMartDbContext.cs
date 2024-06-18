using Microsoft.EntityFrameworkCore;

namespace GoMartWebApp.Models
{
    public class GoMartDbContext : DbContext
    {
        public GoMartDbContext(DbContextOptions<GoMartDbContext> options) : base(options)
        {
            
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderRequest> OrderRequest { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ShippingInfo> ShippingInfo { get; set; }
    }
}
