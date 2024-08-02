

using ETicaret.Application.Abstraction;
using ETicaret.Persistance.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Infrastructure;

public static class ServiceRegisteration
{
    public static void AddPersistanceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService,ProductService>();
    }
}
