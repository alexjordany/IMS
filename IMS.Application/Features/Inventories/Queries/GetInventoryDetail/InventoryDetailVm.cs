namespace IMS.Application.Features.Inventories.Queries.GetInventoryDetail;

public class InventoryDetailVm
{
    public int InventoryId { get; set; }
    public string InventoryName { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }
}
