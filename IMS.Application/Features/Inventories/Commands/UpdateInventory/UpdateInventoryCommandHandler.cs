using AutoMapper;
using IMS.Application.Contracts.Persistence;
using IMS.Application.Exceptions;
using IMS.Domain.Entities;
using MediatR;

namespace IMS.Application.Features.Inventories.Commands.UpdateInventory;

public class UpdateInventoryCommandHandler : IRequestHandler<UpdateInventoryCommand>
{
    private readonly IAsyncRepository<Inventory> _inventoryRepository;
    private readonly IMapper _mapper;

    public UpdateInventoryCommandHandler(IAsyncRepository<Inventory> inventoryRepository, IMapper mapper)
    {
        _inventoryRepository = inventoryRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateInventoryCommand request, CancellationToken cancellationToken)
    {
        var inventoryToUpdate = await _inventoryRepository.GetByIdAsync(request.InventoryId);

        _mapper.Map(request, inventoryToUpdate, typeof(UpdateInventoryCommand), typeof(Inventory));
        await _inventoryRepository.UpdateAsync(inventoryToUpdate);

        return Unit.Value;
    }
}
