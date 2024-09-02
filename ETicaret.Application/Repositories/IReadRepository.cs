using ETicaret.Domain.Entities.Common;
using System.Linq.Expressions;
namespace ETicaret.Application.Repositories;

public interface IReadRepository<T>:IRepoistory<T> where T :BaseEntity
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T,bool>> method);
    Task<T> GetSingleAsync(Expression<Func<T,bool>> method);
    Task<T> GetByIdAsync(string id);
}
