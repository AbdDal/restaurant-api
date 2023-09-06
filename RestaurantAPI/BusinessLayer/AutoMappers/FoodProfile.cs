using AutoMapper;
using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.BusinessLayer.AutoMappers;

public class FoodProfile : Profile
{
    public FoodProfile()
    {
        CreateMap<FoodDto, Food>()
            .ReverseMap();
    }
}