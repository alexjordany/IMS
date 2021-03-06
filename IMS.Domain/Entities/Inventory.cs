using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Domain.Entities;

public class Inventory
{
    public int InventoryId { get; set; }
    public string InventoryName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public List<ProductInventory> ProductInventories { get; set; }
}
