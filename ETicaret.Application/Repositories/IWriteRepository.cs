using ETicaret.Domain.Entities.Common;

namespace ETicaret.Application.Repositories;

public interface IWriteRepository<T> : IRepoistory<T> where T : BaseEntity
{
    Task<bool> AddAsync(T model);
    Task<bool> AddRangeAsync(List<T> model);
    Task<bool> Remove(T model);
    Task<bool> Remove(string id);
    Task<bool> UpdateAsync(T model);
}

