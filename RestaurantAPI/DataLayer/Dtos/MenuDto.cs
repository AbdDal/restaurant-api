using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer.Dtos;

public class MenuDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int RestaurantId { get; set; }
}