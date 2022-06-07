namespace IMS.Application.Features.Products.Queries.GetProductDetail;

public class GetProductDetailQueryHandler : IRequestHandler<GetProductDetailQuery, ProductDetailVM>
{
    private readonly IAsyncRepository<Product> _productRepository;
    private readonly IMapper _mapper;

    public GetProductDetailQueryHandler(IAsyncRepository<Product> productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ProductDetailVM> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetByIdAsync(request.Id);
        return _mapper.Map<ProductDetailVM>(product);
    }
}

