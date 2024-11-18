
using ETicaret.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Persistance;

public static class ServiceRegisteration
{
	public static void AddPersistanceService(this IServiceCollection services)
	{
		services.AddDbContext<DataContext>(opt => opt.UseSqlServer(Configuration.ConnectionString));
	}
	
}
