using Microsoft.EntityFrameworkCore;
using Swiggy_API.Model;

namespace Swiggy_API.Data
{
    public class SwiggyDbContext :DbContext
    {
        public SwiggyDbContext(DbContextOptions options) : base(options)
        {
                    
        }
        public DbSet<ProductModel> productModels { get; set; }
        public DbSet<UserModel> userModels { get; set; }
        public DbSet<OrderModel> orderModels { get; set; }
    }
}

