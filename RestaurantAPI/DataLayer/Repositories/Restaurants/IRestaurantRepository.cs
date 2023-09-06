

using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer.Repositories.Restaurants;

public interface IRestaurantRepository 
{
    public IEnumerable<Restaurant> Entities { get; set; }
    void Insert(Restaurant entity);
    void Update(Restaurant entity);
    void Remove(int id);
    void Commit();
}