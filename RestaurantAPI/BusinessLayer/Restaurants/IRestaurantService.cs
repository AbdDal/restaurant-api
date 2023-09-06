using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Repositories.Restaurants;

namespace RestaurantAPI.BusinessLayer.Restaurants;

public interface IRestaurantService : IRestaurantRepository
{
    IEnumerable<RestaurantDto> GetAll();
    RestaurantDto GetById(int id);
    void Create(RestaurantDto request);
    void Edit(RestaurantDto request);
    void Delete(int id);
}