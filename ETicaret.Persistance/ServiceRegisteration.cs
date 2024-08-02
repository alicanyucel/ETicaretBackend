
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Persistance;

public static class ServiceRegisteration
{
	public static void AddPersistanceService(this IServiceCollection services)
	{
		services.AddDbContext<DataContext>(opt => opt.UseSqlServer("Data Source=DESKTOP-L6NJT48\\\\SQLEXPRESS;Initial Catalog=ECommerceDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;"));
	}
	
}
