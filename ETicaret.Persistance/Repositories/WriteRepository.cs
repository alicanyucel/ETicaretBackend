
using ETicaret.Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Persistance.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : class
{
    public DbSet<T> Table => throw new NotImplementedException();

    public Task<bool> AddAsync(T model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddAsync(List<T> model)
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
