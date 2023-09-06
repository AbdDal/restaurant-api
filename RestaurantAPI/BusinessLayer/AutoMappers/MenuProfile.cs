using AutoMapper;
using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.BusinessLayer.AutoMappers;

public class MenuProfile : Profile
{
    public MenuProfile()
    {
        CreateMap<MenuDto, Menu>();
        CreateMap<Menu, MenuDto>();
    }
}