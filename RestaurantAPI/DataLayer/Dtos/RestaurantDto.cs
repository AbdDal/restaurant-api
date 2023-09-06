using RestaurantAPI.DataLayer.Enums;

namespace RestaurantAPI.DataLayer.Dtos;

public class RestaurantDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    /// <summary>
    /// Represent the type of the restaurant
    /// </summary>
    /// <remarks>Pizza = 1, Burger = 2, Chicken = 3</remarks>
    public RestaurantType RestaurantType { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
}