using ETicaret.Domain.Entities.Common;

namespace ETicaret.Application.Repositories;

public interface IWriteRepository<T> : IRepoistory<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> datas);
    bool Remove(T model);
    Task<bool> RemoveAsync(string id);
    bool Update(T model);
    Task<int> SaveAsync();
    bool RemoveRange(List<T>datas);
}

