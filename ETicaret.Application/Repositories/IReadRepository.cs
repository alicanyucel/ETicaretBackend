using System.Linq.Expressions;
namespace ETicaret.Application.Repositories;

public interface IReadRepository<T>:IRepoistory<T> where T :class
{
    IQueryable<T> GetAll();
    IQueryable<T> GetWhere(Expression<Func<T,bool>> method);
    Task<T> GetSingleAsync(Expression<Func<T,bool>> method);
    Task<T> GetByIdAsync(string id);
}
