using System.ComponentModel.DataAnnotations;
using RestaurantAPI.DataLayer.Enums;

namespace RestaurantAPI.DataLayer.Entities;

public class Restaurant
{
    public int Id { get; set; }
    [Required, StringLength(55)]
    public string Name { get; set; }
    [Required, StringLength(200)]
    public string Address { get; set; }
    [Required]
    public RestaurantType RestaurantType { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required, Phone]
    public string PhoneNumber { get; set; }
}