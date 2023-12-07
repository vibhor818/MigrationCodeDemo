using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationCodeDemo.MyContexts
{
    public class VBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=(localdb)\mssqllocaldb;database=migrationbtest;trusted_connection=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerMobile { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
    public class Order
    {
        public int OrderId { get; set;}
        public string OrderName { get; set; }
        public string OrderDesc { get; set; }
        public Customer Customer { get; set; }
    }
    
}
