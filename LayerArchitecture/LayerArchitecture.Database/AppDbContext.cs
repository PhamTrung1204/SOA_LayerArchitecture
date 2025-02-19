using Microsoft.EntityFrameworkCore;
using LayerArchitecture.Database.Models;
using System.Collections.Generic;

namespace LayerArchitecture.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
