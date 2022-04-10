using AutoMapper;
using IMS.Application.Contracts.Persistence;
using IMS.Domain.Entities;
using MediatR;

namespace IMS.Application.Features.Inventories.Queries.GetInventoryDetail;

public class GetInventoryDetailQueryHandler : IRequestHandler<GetInventoryDetailQuery, InventoryDetailVm>
{
    private readonly IAsyncRepository<Inventory> _inventoryRepository;
    private readonly IMapper _mapper;

    public GetInventoryDetailQueryHandler(IAsyncRepository<Inventory> inventoryRepository, IMapper mapper)
    {
        _inventoryRepository = inventoryRepository;
        _mapper = mapper;
    }

    public async Task<InventoryDetailVm> Handle(GetInventoryDetailQuery request, CancellationToken cancellationToken)
    {
        var inventory = await _inventoryRepository.GetByIdAsync(request.Id);
        return _mapper.Map<InventoryDetailVm>(inventory);
    }
}
