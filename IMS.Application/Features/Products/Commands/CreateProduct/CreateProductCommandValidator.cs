﻿using FluentValidation;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Products.Commands.CreateProduct;

public class CreateProductCommandValidator :AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    { 
        RuleFor(p => p.ProductName).NotEmpty().WithMessage("{PropertyName} is required.").MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");
        RuleFor(p => p.Quantity).GreaterThan(0).WithMessage("Quantity must be greater or equal to 0");
        //RuleFor(p => p.Price).GreaterThan(0).When(p => p.ProductInventories != null || p.ProductInventories.Count < 0).GreaterThanOrEqualTo(p => p.ProductInventories.Sum(x => x.Inventory.Price * x.InventoryQuantity)).WithMessage("The product's price is less than the summary of its inventories' price: {ComparisonValue}");
        //RuleFor(p => p.Price).GreaterThanOrEqualTo(p => p.ProductInventories.Sum(x => x.Inventory.Price * x.InventoryQuantity)).When(p=> p.ProductInventories != null || p.ProductInventories.Count < 0).WithMessage("The product's price is less than the summary of its inventories' price: {ComparisonValue}");
    }
}