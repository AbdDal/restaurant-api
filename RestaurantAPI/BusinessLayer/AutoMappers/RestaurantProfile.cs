using AutoMapper;
using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.BusinessLayer.AutoMappers;

public class RestaurantProfile : Profile
{
    public RestaurantProfile()
    {
        CreateMap<RestaurantDto, Restaurant>().ReverseMap();
            
    }
}