
using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Persistance.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly DbContext _context;
    public WriteRepository(DbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => throw new NotImplementedException();

    public Task<bool> AddAsync(T model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddRangeAsync(List<T> model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Remove(T model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Remove(string id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(T model)
    {
        throw new NotImplementedException();
    }
}
