using IMS.Domain.Common;

namespace IMS.Domain.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public bool IsActive { get; set; }

    public List<ProductInventory>? ProductInventories { get; set; }

}
