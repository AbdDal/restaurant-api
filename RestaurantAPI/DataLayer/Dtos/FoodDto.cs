namespace RestaurantAPI.DataLayer.Dtos;

public class FoodDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MenuId { get; set; }
}