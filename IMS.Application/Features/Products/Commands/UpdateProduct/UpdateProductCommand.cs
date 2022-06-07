namespace IMS.Application.Features.Products.Commands.UpdateProduct;

public class UpdateProductCommand : IRequest
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }

    public double Price { get; set; }

    public List<ProductInventory>? ProductInventories { get; set; }

}
