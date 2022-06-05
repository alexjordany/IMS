using IMS.Domain.Entities;

namespace IMS.Application.Contracts.Persistence;

public interface IProductRepository : IAsyncRepository<Product>
{
    Task<IEnumerable<Product>> GetProductsByName(string name);
}
