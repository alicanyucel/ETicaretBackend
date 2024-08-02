

using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Persistance.Contexts;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions options):base(options)
    {
        
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
}
