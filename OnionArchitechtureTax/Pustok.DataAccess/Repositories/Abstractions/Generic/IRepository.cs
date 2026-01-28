using Microsoft.EntityFrameworkCore;
using Pustok.Core.Entities.Common;

namespace Pustok.DataAccess.Repositories;

public interface IRepository<T> where T : BaseEntity, new()
{
    DbSet<T> Table { get; }

    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);

    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);

    Task<int> SaveAsync();
}
