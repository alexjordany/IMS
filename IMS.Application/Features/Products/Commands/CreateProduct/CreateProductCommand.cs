using IMS.Domain.Entities;
using MediatR;

namespace IMS.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommand : IRequest<int>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public List<ProductInventory> ProductInventories { get; set; }

    public bool ValidatePricing()
    {
        if (ProductInventories == null || ProductInventories.Count <= 0)
            return true;

        double priceOfAllInvs = this.ProductInventories.Sum(x => x.Inventory?.Price ?? 0);
        if (priceOfAllInvs < Price) return false;

        return true;
    }

}
