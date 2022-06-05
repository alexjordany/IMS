using IMS.Domain.Entities;
using MediatR;

namespace IMS.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommand : IRequest<int>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }

    [EnsurePriceIsGreaterThanInventoriesPrice]
    public double Price { get; set; }

    public List<ProductInventory> ProductInventories { get; set; }

    public double TotalInventoryCost()
    {
        return ProductInventories.Sum(x => x.Inventory?.Price * x.InventoryQuantity ?? 0);
    }

    public bool ValidatePricing()
    {
        if (ProductInventories == null || ProductInventories.Count <= 0)
            return true;

        if (TotalInventoryCost() > Price) return false;

        return true;
    }

}
