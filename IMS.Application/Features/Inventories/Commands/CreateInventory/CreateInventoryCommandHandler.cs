using AutoMapper;
using IMS.Application.Contracts.Persistence;
using IMS.Domain.Entities;
using MediatR;

namespace IMS.Application.Features.Inventories.Commands.CreateInventory;

public class CreateInventoryCommandHandler : IRequestHandler<CreateInventoryCommand,int>
{
    private readonly IInventoryRepository _inventoryRepository;
    private readonly IMapper _mapper;

    public CreateInventoryCommandHandler(IInventoryRepository inventoryRepository, IMapper mapper)
    {
        _inventoryRepository = inventoryRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateInventoryCommand request, CancellationToken cancellationToken)
    {
        var inventory = _mapper.Map<Inventory>(request);
        inventory = await _inventoryRepository.AddAsync(inventory);
        return inventory.InventoryId;
    }
}
