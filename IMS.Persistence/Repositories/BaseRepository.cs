using IMS.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IMS.Persistence.Repositories;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected readonly IMSDbContext _dbContext;
    public BaseRepository(IMSDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public Task DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
