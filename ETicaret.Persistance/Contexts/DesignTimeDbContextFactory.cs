
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicaret.Persistance.Contexts
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<DbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer("Data Source=DESKTOP-L6NJT48\\SQLEXPRESS;Initial Catalog=ECommerceDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;");
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
