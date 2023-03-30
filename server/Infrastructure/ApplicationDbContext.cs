using E_Commerce.Domain;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Infrastructure
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<ProductDetail> ProductDetails { get; set; }

    }
}