using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Application.Features.Products.Commands.CreateProduct
{
    internal class EnsurePriceIsGreaterThanInventoriesPrice: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var product = validationContext.ObjectInstance as CreateProductCommand;
            if(product != null)
            {
                if (!product.ValidatePricing())
                    return new ValidationResult($"The price of the product is less than the sum of the price of the inventories which is: {product.TotalInventoryCost()}", new[] {validationContext.MemberName});
            }
            return ValidationResult.Success;
        }
    }
}
