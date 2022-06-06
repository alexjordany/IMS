using System.ComponentModel.DataAnnotations;
using FluentValidation;
using IMS.Application.Features.Products.Commands.CreateProduct;

namespace IMS.Application.Features.Products.Commands.UpdateProduct;

public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(p => p.ProductName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
        RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Quantity must be greater or equal to 0");
    }
}
internal class EnsurePriceIsGreaterThanInventoriesPriceUpdate : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var product = validationContext.ObjectInstance as UpdateProductCommand;
        if (product != null)
        {
            if (!product.ValidatePricing())
                return new ValidationResult($"The price of the product is less than the sum of the price of the inventories which is: {product.TotalInventoryCost()}", new[] { validationContext.MemberName });
        }
        return ValidationResult.Success;
    }
}

