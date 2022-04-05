using AutoMapper;
using IMS.Application.Features.Inventories.Commands.CreateInventory;
using IMS.Application.Features.Inventories.Queries.ViewInventoriesByName;
using IMS.Domain.Entities;

namespace IMS.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Inventory, ViewInventoriesByNameVM>().ReverseMap();
        CreateMap<Inventory, CreateInventoryCommand>().ReverseMap();
    }
}
