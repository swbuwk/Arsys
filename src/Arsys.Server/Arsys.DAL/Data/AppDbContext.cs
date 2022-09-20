using Arsys.Domain.Entities.Common;
using Arsys.Domain.Entities.Storage;
using Microsoft.EntityFrameworkCore;

namespace Arsys.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Product> Cards { get; set; }
        public DbSet<Category> Users { get; set; }
        public DbSet <Supply> Supplies { get; set; }
    }
}
