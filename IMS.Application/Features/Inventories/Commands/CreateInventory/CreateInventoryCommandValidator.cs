using FluentValidation;

namespace IMS.Application.Features.Inventories.Commands.CreateInventory;

public class CreateInventoryCommandValidator : AbstractValidator<CreateInventoryCommand>
{
    public CreateInventoryCommandValidator()
    {
        RuleFor(p => p.InventoryName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

        RuleFor(p => p.Price).GreaterThan(0).WithMessage("Price must be greater or equal to 0");

        RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Quantity must be greater or equal to 0");
    }
}