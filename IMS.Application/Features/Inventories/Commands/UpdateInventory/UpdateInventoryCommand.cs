namespace IMS.Application.Features.Inventories.Commands.UpdateInventory;

public class UpdateInventoryCommand : IRequest
{
    public int InventoryId { get; set; }

    public string InventoryName { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }
}
