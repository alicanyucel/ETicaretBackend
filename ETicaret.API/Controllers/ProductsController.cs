
using ETicaret.Application.Abstraction;
using ETicaret.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ETicaret.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;
        public ProductsController( IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;

        }
        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(),Name="Laptop",Price=1000,CreatedDate=DateTime.Now,Stock=10},
                 new(){Id=Guid.NewGuid(),Name="Ayakkabi",Price=3000,CreatedDate=DateTime.Now,Stock=20},
                  new(){Id=Guid.NewGuid(),Name="Canta",Price=2000,CreatedDate=DateTime.Now,Stock=30},
            });
            var count = await _productWriteRepository.SaveAsync();
        }
    }
}
