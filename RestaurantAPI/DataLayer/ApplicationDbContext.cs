using Microsoft.EntityFrameworkCore;
using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Food> Foods { get; set; }
}