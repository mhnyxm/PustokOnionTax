using Microsoft.EntityFrameworkCore;
using Pustok.Core.Entities.Common;
using Pustok.DataAccess.Contexts;

namespace Pustok.DataAccess.Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : BaseEntity,new()
{
    private readonly PustokDBContext _context;

    public Repository(PustokDBContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();


    public async Task<List<T>> GetAllAsync()
    {
        var entities = await Table.ToListAsync();
        return entities;
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        var entity = await Table.FindAsync(id);
        return entity;
    }

    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
    }

    public void Update(T entity)
    {
        Table.Update(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public async Task<int> SaveAsync()
    {
        int rows = await _context.SaveChangesAsync();
        return rows;
    }
}
