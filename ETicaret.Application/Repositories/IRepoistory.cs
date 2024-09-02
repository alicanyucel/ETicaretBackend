
using ETicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Application.Repositories;

public interface IRepoistory<T> where T : BaseEntity
{
    DbSet<T> Table {  get;  }
}