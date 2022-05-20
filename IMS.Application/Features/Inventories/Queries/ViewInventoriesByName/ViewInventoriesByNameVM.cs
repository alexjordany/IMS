using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories.Queries.ViewInventoriesByName
{
    public class ViewInventoriesByNameVM
    {
        public int InventoryId { get; set; }
        public string InventoryName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public List<ProductInventory> ProductInventories { get; set; }

    }
}
