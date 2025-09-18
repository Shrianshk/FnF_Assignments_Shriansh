using BlazorApp.Shared;
using Microsoft.EntityFrameworkCore;

namespace BalzorApp.WebApi.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
