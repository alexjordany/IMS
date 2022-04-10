using MediatR;

namespace IMS.Application.Features.Inventories.Queries.GetInventoryDetail;

public class GetInventoryDetailQuery : IRequest<InventoryDetailVm>
{
    public int Id { get; set; }
}
