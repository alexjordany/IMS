namespace IMS.Application.Features.Products.Queries.GetProductsByName;

public class GetProductsByNameQuery : IRequest<List<GetProductsByNameVM>>
{
    public string? Name { get; set; }
}
