using IMS.Domain.Entities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using IMS.Application.Features.Inventories.Commands.CreateInventory;

namespace IMS.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddAplicationServices (this IServiceCollection services)
    {
        services.AddFluentValidation(opt => opt.RegisterValidatorsFromAssemblyContaining<CreateInventoryCommandValidator>());
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
