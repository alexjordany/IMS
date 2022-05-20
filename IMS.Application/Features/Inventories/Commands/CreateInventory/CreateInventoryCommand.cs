using MediatR;

namespace IMS.Application.Features.Inventories.Commands.CreateInventory;

public class CreateInventoryCommand : IRequest<int>
{
    public string InventoryName { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }
}
