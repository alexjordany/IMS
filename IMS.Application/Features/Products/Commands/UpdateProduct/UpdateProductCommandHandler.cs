using AutoMapper;
using IMS.Application.Contracts.Persistence;
using IMS.Domain.Entities;
using MediatR;

namespace IMS.Application.Features.Products.Commands.UpdateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IAsyncRepository<Product> _productRepository;
    private readonly IMapper _mapper;

    public UpdateProductCommandHandler(IMapper mapper, IAsyncRepository<Product> productRepository)
    {
        _mapper = mapper;
        _productRepository = productRepository;
    }

    public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var productToUpdate = await _productRepository.GetByIdAsync(request.ProductId);
        _mapper.Map(request, productToUpdate, typeof(UpdateProductCommand), typeof(Product));
        await _productRepository.UpdateAsync(productToUpdate);
        return Unit.Value;
    }
}

