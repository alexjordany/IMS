namespace IMS.Application.Features.Products.Queries.GetProductDetail;

public class ProductDetailVM
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

    public List<ProductInventory>? ProductInventories { get; set; }
}

