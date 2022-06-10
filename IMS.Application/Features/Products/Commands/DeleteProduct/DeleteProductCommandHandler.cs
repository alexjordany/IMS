using System;

namespace IMS.Application.Features.Products.Commands.DeleteProduct
{
	public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
	{
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public DeleteProductCommandHandler(IAsyncRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var productToDelete = await _productRepository.GetByIdAsync(request.ProductId);
            _mapper.Map(request, productToDelete, typeof(DeleteProductCommand), typeof(Product));
            await _productRepository.UpdateAsync(productToDelete);
            return Unit.Value;
        }
    }
}

