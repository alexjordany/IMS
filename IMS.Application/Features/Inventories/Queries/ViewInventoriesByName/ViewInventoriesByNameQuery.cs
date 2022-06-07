namespace IMS.Application.Features.Inventories.Queries.ViewInventoriesByName;

public class ViewInventoriesByNameQuery : IRequest<List<ViewInventoriesByNameVM>>
{
    public string? Name { get; set; }
}
