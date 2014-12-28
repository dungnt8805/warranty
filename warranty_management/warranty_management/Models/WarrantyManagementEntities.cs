using System.Data.Entity;

namespace warranty_management.Models
{
    public class WarrantyManagementEntities : DbContext
    {
        public DbSet<Manufacturer> Manufactures { get; set; }
        public DbSet<Specie> Species { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        //public DbSet<Warranty> Warranties { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<> Manufactures { get; set; }
    }
}