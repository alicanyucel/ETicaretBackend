

using ETicaret.Application.Abstraction;
using ETicaret.Domain.Entities;

namespace ETicaret.Persistance.Concrete;

public class ProductService : IProductService
{
    public List<Product> GetProducts() => new()
    {
        new () {Id=Guid.NewGuid(),Name="Product1",Stock=11,Price=100},
          new () {Id=Guid.NewGuid(),Name="Product2",Stock=12,Price=200},
            new () {Id=Guid.NewGuid(),Name="Product3",Stock=13,Price=300},
              new () {Id=Guid.NewGuid(),Name="Product4",Stock=14,Price=400},
                new () {Id=Guid.NewGuid(),Name="Product5",Stock=15,Price=500}
    };
}
