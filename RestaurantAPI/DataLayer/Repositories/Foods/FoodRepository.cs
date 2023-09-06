

using RestaurantAPI.DataLayer.Entities;

namespace RestaurantAPI.DataLayer.Repositories.Foods;

public class FoodRepository : IFoodRepository
{
    private readonly ApplicationDbContext _dbContext;

    public FoodRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        Entities = _dbContext.Set<Food>();
    }

    public IEnumerable<Food> Entities { get; set; }
    public void Insert(Food entity)
    {
        _dbContext.Add(entity);
    }

    public void Update(Food entity)
    {
        _dbContext.Update(entity); }

    public void Remove(int id)
    {
        var entity = _dbContext.Foods.FirstOrDefault(x => x.Id == id);

        if (entity != null) _dbContext.Foods.Remove(entity);
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }
}