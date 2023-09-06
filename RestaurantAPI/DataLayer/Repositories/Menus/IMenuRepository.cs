

using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer.Repositories.Menus;

public interface IMenuRepository 
{
    public IEnumerable<Menu> Entities { get; set; }
    void Insert(Menu entity);
    void Update(Menu entity);
    void Remove(int id);
    void Commit();
}