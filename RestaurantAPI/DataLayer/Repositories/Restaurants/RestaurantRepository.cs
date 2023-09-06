using Microsoft.EntityFrameworkCore;
using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer.Repositories.Restaurants;

public class RestaurantRepository : IRestaurantRepository
{
    private readonly ApplicationDbContext _dbContext;

    public RestaurantRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        Entities = _dbContext.Set<Restaurant>();
    }

    public IEnumerable<Restaurant> Entities { get; set; }
    public void Insert(Restaurant entity)
    {
        _dbContext.Add(entity);
    }

    public void Update(Restaurant entity)
    {
        _dbContext.Update(entity);
    }

    public void Remove(int id)
    {
        var entity = _dbContext.Restaurants.FirstOrDefault(x => x.Id == id);

        if (entity != null) _dbContext.Restaurants.Remove(entity);
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }
}