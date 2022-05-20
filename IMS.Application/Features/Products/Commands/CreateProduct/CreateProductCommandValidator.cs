using FluentValidation;

namespace IMS.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandValidator :AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(p => p.ProductName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

        RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greater or equal to 0");

        RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Quantity must be greater or equal to 0");
    }
}
