
using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaret.Persistance.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly DbContext _context;
    public WriteRepository(DbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();
    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);
        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> datas)
    {
        await Table.AddRangeAsync(datas);
        return true;

    }

    public bool Remove(T model)
    {
        EntityEntry<T> entity = Table.Remove(model);
        return entity.State == EntityState.Deleted;
    }
    public bool RemoveRange(List<T> datas)
    {
        Table.RemoveRange(datas);
        return true;

    }
    public async Task<bool> RemoveAsync(string id)
    {
        T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        return Remove(model);
    }

    public async Task<int> SaveAsync()=>await _context.SaveChangesAsync();
    

    public bool Update(T model)
    {
        EntityEntry entityEntry =Table.Update(model);
        return entityEntry.State == EntityState.Modified;
    }
}
