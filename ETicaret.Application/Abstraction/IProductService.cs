using ETicaret.Domain.Entities;

namespace ETicaret.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
