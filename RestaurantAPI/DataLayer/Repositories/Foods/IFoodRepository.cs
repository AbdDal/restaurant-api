

using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer.Repositories.Foods;

public interface IFoodRepository 
{
    public IEnumerable<Food> Entities { get; set; }
    void Insert(Food entity);
    void Update(Food entity);
    void Remove(int id);
    void Commit();
}