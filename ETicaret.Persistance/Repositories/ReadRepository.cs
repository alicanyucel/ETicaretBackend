
using ETicaret.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETicaret.Persistance.Repositories;

internal class ReadRepository<T> : IReadRepository<T> where T : class
{
    public DbSet<T> Table => throw new NotImplementedException();

    public IQueryable<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
    {
        throw new NotImplementedException();
    }
}
