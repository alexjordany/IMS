using IMS.Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using IMS.Application.Features.Inventories.Commands.CreateInventory;
using IMS.Application.Features.Inventories.Commands.UpdateInventory;
using IMS.Application.Features.Products.Commands.CreateProduct;
using IMS.Application.Features.Products.Commands.UpdateProduct;

namespace IMS.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddAplicationServices (this IServiceCollection services)
    {
        //services.AddFluentValidation(opt => opt.RegisterValidatorsFromAssemblyContaining<CreateInventoryCommandValidator>());
        services.AddFluentValidation();

        services.AddScoped<IValidator<CreateInventoryCommand>, CreateInventoryCommandValidator>();
        services.AddScoped<IValidator<UpdateInventoryCommand>, UpdateInventoryCommandValidator>();
        services.AddScoped<IValidator<CreateProductCommand>, CreateProductCommandValidator>();
        services.AddScoped<IValidator<UpdateProductCommand>, UpdateProductCommandValidator>();



        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
