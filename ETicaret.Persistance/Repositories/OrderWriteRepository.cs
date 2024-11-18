using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Persistance.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(DbContext context) : base(context)
        {
        }
    }
}
