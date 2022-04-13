using IMS.Application.Contracts.Persistence;
using IMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IMS.Persistence.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(IMSDbContext dbContext) : base(dbContext)
    {

    }
    public async Task<IEnumerable<Product>> GetProductsByName(string name)
    {
        var productsByName = await _dbContext.Products.Where(x => x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(name)).ToListAsync();
        return productsByName;
    }
}
