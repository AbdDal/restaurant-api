using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Entities;
using RestaurantAPI.DataLayer.Repositories.Foods;
using RestaurantAPI.DataLayer.Repositories.Menus;

namespace RestaurantAPI.BusinessLayer.Menus;

public interface IMenuService : IMenuRepository
{
    IEnumerable<MenuDto> GetAll();
    MenuDto GetById(int id);
    void Create(MenuDto request);
    void Edit(MenuDto request);
    void Delete(int id);
}