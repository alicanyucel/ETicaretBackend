
using Microsoft.EntityFrameworkCore;

namespace ETicaret.Application.Repositories;

public interface IRepoistory<T> where T : class
{
    DbSet<T> Table {  get;  }
}