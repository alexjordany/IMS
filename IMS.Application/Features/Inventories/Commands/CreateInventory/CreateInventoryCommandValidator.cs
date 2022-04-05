using FluentValidation;

namespace IMS.Application.Features.Inventories.Commands.CreateInventory;

public class CreateInventoryCommandValidator : AbstractValidator<CreateInventoryCommand>
{
    public CreateInventoryCommandValidator()
    {
        RuleFor(p => p.InventoryName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

        RuleFor(p => p.Price).InclusiveBetween(0, double.MaxValue).WithMessage("Price must be greater or equal to 0");

        RuleFor(p => p.Quantity).InclusiveBetween(0, int.MaxValue).WithMessage("Quantity must be greater or equal to 0");
    }
}
