using Arsys.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Arsys.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Product> Cards { get; set; }
        public DbSet<Category> Users { get; set; }
    }
}
