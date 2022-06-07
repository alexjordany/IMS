namespace IMS.Application.Features.Inventories.Queries.ViewInventoriesByName;

public class ViewInventoriesByNameQueryHandler :IRequestHandler<ViewInventoriesByNameQuery, List<ViewInventoriesByNameVM>>
{
    private readonly IInventoryRepository _inventoryRepository;
    private readonly IMapper _mapper;

    public ViewInventoriesByNameQueryHandler(IInventoryRepository inventoryRepository, IMapper mapper)
    {
        _inventoryRepository = inventoryRepository;
        _mapper = mapper;
    }

    public async Task<List<ViewInventoriesByNameVM>> Handle(ViewInventoriesByNameQuery request, CancellationToken cancellationToken)
    {
        var viewByName = await _inventoryRepository.GetInventoriesByName(request.Name);
        return _mapper.Map<List<ViewInventoriesByNameVM>>(viewByName);
    }


}
