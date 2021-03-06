using car_dealership.Models;
using Microsoft.EntityFrameworkCore;

namespace car_dealership.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions<SalesContext> options) : base(options)
        {
        }

        public DbSet<Car> Car {get; set;}
        public DbSet<Customer> Customer {get; set;}
        public DbSet<Manager> Manager {get; set;}
        public DbSet<Deal> Deal {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Manager>().ToTable("Managers");
            modelBuilder.Entity<Deal>().ToTable("Deals");
        }
    }
}