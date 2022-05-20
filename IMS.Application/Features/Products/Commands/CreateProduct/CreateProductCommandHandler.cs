using AutoMapper;
using IMS.Application.Contracts.Persistence;
using IMS.Domain.Entities;
using MediatR;

namespace IMS.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand,int>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = _mapper.Map<Product>(request);
        product = await _productRepository.AddAsync(product);
        return product.ProductId;
    }
}
