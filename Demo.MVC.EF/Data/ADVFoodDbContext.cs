using Demo.MVC.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.MVC.EF.Data
{
    public class ADVFoodDbContext : DbContext
    {
        public ADVFoodDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed Data
            // Fluent apis helps us define the relationships between models
            // Modelbuilder class helps us to define the initail data model and its relationships

            modelBuilder.Entity<Customers>().HasKey(x => x.Id);
            modelBuilder.Entity<Customers>().Property(x => x.City).HasMaxLength(100);
            modelBuilder.Entity<Customers>().Property(x => x.Email).HasMaxLength(100);

            modelBuilder.Entity<Customers>().HasData(new Customers()
            {
                Id = 1,
                Contact = "12345",
                City = "Hyderabad",
                Email = "ms@bbc.com",
                Name = "John"

            },
            new Customers()
            {
                Id = 2,
                Contact = "45687",
                City = "Punjab",
                Email = "ms2@bbc.com",
                Name = "Ron"

            },
            new Customers()
            {
                Id = 3,
                Contact = "04669",
                City = "Nagpur",
                Email = "ms3@bbc.com",
                Name = "Tony"

            }
            );

            modelBuilder.Entity<Orders>().HasKey(x => x.Id);

            modelBuilder.Entity<Orders>().HasData(new Orders()
            {
                Id = 101,
                CustomerId = 1,
                CreatedDate = DateTime.Now,
                Quantity = 1,
                TotalAmount = 0

            },
            new Orders()
            {
                Id = 102,
                CustomerId = 1,
                CreatedDate = DateTime.Now,
                Quantity = 1,
                TotalAmount = 0

            }, new Orders()
            {
                Id = 103,
                CustomerId = 2,
                CreatedDate = DateTime.Now,
                Quantity = 1,
                TotalAmount = 0

            });


            modelBuilder.Entity<Orders>().HasOne(x => x.Customers).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);
            modelBuilder.Entity<OrderItems>().HasOne(x => x.Orders).WithMany(x => x.OrderItems).HasForeignKey(x => x.OrderId);
            modelBuilder.Entity<OrderItems>().HasOne(x => x.Items).WithMany(x => x.OrderItems).HasForeignKey(x => x.ItemsId);

            modelBuilder.Entity<OrderItems>().HasKey(x => x.Id);

            modelBuilder.Entity<Items>().HasKey(x => x.Id);

            modelBuilder.Entity<Items>().HasData(new Items()
            {
                Id = 1,
                Name = "Dosa",
                Category = "Tiffin",
                Price = 20
            },
            new Items()
            {
                Id = 2,
                Name = "Cool Drinks",
                Category = "Beverages",
                Price = 30
            },
            new Items()
            {
                Id = 3,
                Name = "Coffe",
                Category = "Beverages",
                Price = 10
            },
            new Items()
            {
                Id = 4,
                Name = "Meals",
                Category = "Lunch",
                Price = 100
            }
            );

            modelBuilder.Entity<OrderItems>().HasData(
                new OrderItems() { Id = 1, ItemsId = 1, OrderId = 101 },
                new OrderItems() { Id = 2, ItemsId = 3, OrderId = 101 },
                new OrderItems() { Id = 3, ItemsId = 4, OrderId = 101 },
                new OrderItems() { Id = 4, ItemsId = 1, OrderId = 102 },
                new OrderItems() { Id = 5, ItemsId = 2, OrderId = 102 },
                new OrderItems() { Id = 6, ItemsId = 4, OrderId = 103 });



        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Items> Items { get; set; }

    }
}
