
using ETicaret.Application.Repositories;
using ETicaret.Persistance.Contexts;
using ETicaret.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Persistance;

public static class ServiceRegisteration
{
	public static void AddPersistanceService(this IServiceCollection services)
	{
		services.AddDbContext<DataContext>(opt => opt.UseSqlServer(Configuration.ConnectionString),ServiceLifetime.Singleton);
		services.AddSingleton<ICustomerReadRepository,CustomerReadRepository>();
        services.AddSingleton<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddSingleton<IOrderReadRepository,OrderReadRepository>();
        services.AddSingleton<IOrderWriteRepository, OrderWriteRepository>();
        services.AddSingleton<IProductReadRepository,ProductReadRepository>();
        services.AddSingleton<IProductWriteRepository, ProductWriteRepository>();
    }
	
}
