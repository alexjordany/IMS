using IMS.Application.Contracts.Persistence;
using IMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace IMS.Persistence.Repositories
{
    public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(IMSDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            //var inventoriesByName = await _dbContext.Inventories.Where(x=> x.InventoryName.Contains(name)).ToListAsync();
            //return inventoriesByName;


            //return await _dbContext.Inventories.Where(x=> x.InventoryName.Contains(name) || string.IsNullOrWhiteSpace(name)).ToListAsync();
            var inventoriesByName = await _dbContext.Inventories.Where(x => x.InventoryName.Contains(name) || string.IsNullOrWhiteSpace(name)).ToListAsync();
            return inventoriesByName;
        }
    }
}
