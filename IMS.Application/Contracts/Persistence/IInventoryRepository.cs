using IMS.Domain.Entities;

namespace IMS.Application.Contracts.Persistence;

public interface IInventoryRepository
{
    Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
}
