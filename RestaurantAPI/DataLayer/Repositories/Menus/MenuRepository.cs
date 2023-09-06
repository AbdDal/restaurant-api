

using Microsoft.EntityFrameworkCore;
using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer.Repositories.Menus;

public class MenuRepository : IMenuRepository
{
    private readonly ApplicationDbContext _dbContext;
    public IEnumerable<Menu> Entities { get; set; }

    public MenuRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        Entities = _dbContext.Menus.Include(x=>x.Foods);
    }

    public void Insert(Menu entity)
    {
        _dbContext.Menus.Add(entity);
    }

    public void Update(Menu entity)
    {
        _dbContext.Menus.Update(entity);
    }

    public void Remove(int id)
    {
        var entity = _dbContext.Menus.FirstOrDefault(x => x.Id == id);
        
        if (entity != null) _dbContext.Menus.Remove(entity);
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }
}