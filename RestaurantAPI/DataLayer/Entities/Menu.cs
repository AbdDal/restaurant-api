using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.DataLayer.Entities;

public class Menu
{
    public int Id { get; set; }

    [Required, StringLength(55)]
    public string Name { get; set; }
    
    [ForeignKey(nameof(Restaurant))]
    public int RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; }
    
    public ICollection<Food> Foods { get; set; }
}