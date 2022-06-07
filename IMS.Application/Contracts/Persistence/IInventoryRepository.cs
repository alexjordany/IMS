namespace IMS.Application.Contracts.Persistence;

public interface IInventoryRepository : IAsyncRepository<Inventory>
{
    Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
}
