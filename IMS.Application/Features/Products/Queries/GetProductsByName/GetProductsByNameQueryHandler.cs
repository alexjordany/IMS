namespace IMS.Application.Features.Products.Queries.GetProductsByName
{
    public class GetProductsByNameQueryHandler : IRequestHandler<GetProductsByNameQuery, List<GetProductsByNameVM>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsByNameQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<GetProductsByNameVM>> Handle(GetProductsByNameQuery request, CancellationToken cancellationToken)
        {
            var getByName = await _productRepository.GetProductsByName(request.Name);
            return _mapper.Map<List<GetProductsByNameVM>>(getByName);
        }
    }
}