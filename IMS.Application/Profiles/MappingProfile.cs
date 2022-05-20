﻿using AutoMapper;
using IMS.Application.Features.Inventories.Commands.CreateInventory;
using IMS.Application.Features.Inventories.Commands.UpdateInventory;
using IMS.Application.Features.Inventories.Queries.GetInventoryDetail;
using IMS.Application.Features.Inventories.Queries.ViewInventoriesByName;
using IMS.Application.Features.Products.Commands.CreateProduct;
using IMS.Application.Features.Products.Queries.GetProductsByName;
using IMS.Domain.Entities;

namespace IMS.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Inventory, ViewInventoriesByNameVM>().ReverseMap();
        CreateMap<Inventory, CreateInventoryCommand>().ReverseMap();
        CreateMap<Inventory, UpdateInventoryCommand>().ReverseMap(); 
        CreateMap<Inventory, InventoryDetailVm>().ReverseMap();

        CreateMap<Product, GetProductsByNameVM>().ReverseMap();
        CreateMap<Product, CreateProductCommand>().ReverseMap();
    }
}
