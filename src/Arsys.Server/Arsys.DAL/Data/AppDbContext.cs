using Arsys.Domain.Entities.Common;
using Arsys.Domain.Entities.Storage;
using Order = Arsys.Domain.Entities.CashDesk.Order;

namespace Arsys.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supply> Supplies { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //инициализация бд начальными значениями

            var desserts = new Category {Id = Guid.NewGuid(), Name = "Desserts"};
            var beverages = new Category {Id = Guid.NewGuid(), Name = "Beverages"};
            var chicken = new Category {Id = Guid.NewGuid(), Name = "Chicken"};
            var beef = new Category {Id = Guid.NewGuid(), Name = "Beef"};

            modelBuilder.Entity<Category>()
                .HasData(desserts, beverages, chicken, beef);
            modelBuilder.Entity<Product>()
                .HasData(
                new Product {Id = Guid.NewGuid(), CategoryId = desserts.Id, Name = "Teramisu", Price = 4},
                new Product {Id = Guid.NewGuid(), CategoryId = desserts.Id, Name = "Ice cream", Price = 1},
                
                new Product {Id = Guid.NewGuid(), CategoryId = beverages.Id, Name = "Coke", Price = 2},
                new Product {Id = Guid.NewGuid(), CategoryId = beverages.Id, Name = "Water", Price = 1},
                
                new Product {Id = Guid.NewGuid(), CategoryId = chicken.Id, Name = "Burger", Price = 4},
                new Product {Id = Guid.NewGuid(), CategoryId = chicken.Id, Name = "Shnical", Price = 2},
                
                new Product {Id = Guid.NewGuid(), CategoryId = beef.Id, Name = "Burger", Price = 4},
                new Product {Id = Guid.NewGuid(), CategoryId = beef.Id, Name = "Kotleta", Price = 2}
            );

        }
    }
    
}


