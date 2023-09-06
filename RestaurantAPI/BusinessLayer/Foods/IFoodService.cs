using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Repositories.Foods;

namespace RestaurantAPI.BusinessLayer.Foods;

public interface IFoodService : IFoodRepository
{
    IEnumerable<FoodDto> GetAll();
    FoodDto GetById(int id);
    void Create(FoodDto request);
    void Edit(FoodDto request);
    void Delete(int id);
}