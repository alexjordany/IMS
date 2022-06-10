namespace IMS.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommand : IRequest<int>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public bool IsActive { get; set; } = true;

    public List<ProductInventory> ProductInventories { get; set; }

}
