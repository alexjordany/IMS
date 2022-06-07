namespace IMS.Application.Features.Products.Queries.GetProductDetail;

public class GetProductDetailQuery : IRequest<ProductDetailVM>
{
    public int Id { get; set; }
}

