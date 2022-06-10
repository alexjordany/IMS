namespace IMS.Application.Features.Products.Queries.GetProductsByName;

public class GetProductsByNameVM
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public bool IsActive { get; set; }
}
