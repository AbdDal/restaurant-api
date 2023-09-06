using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.DataLayer.Entities;

public class Food
{
    public int Id { get; set; }
    [Required, StringLength(55)]
    public string Name { get; set; }
    [Required, StringLength(200)]
    public string Description { get; set; }

    [ForeignKey(nameof(Menu))]
    public int MenuId { get; set; }
    public Menu Menu { get; set; }
}