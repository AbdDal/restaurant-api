using System.Transactions;
using AutoMapper;
using RestaurantAPI.DataLayer;
using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Entities;
using RestaurantAPI.DataLayer.Repositories.Foods;

namespace RestaurantAPI.BusinessLayer.Foods;

public class FoodService : FoodRepository, IFoodService
{
    private readonly IMapper _mapper;

    public FoodService(ApplicationDbContext dbContext
        , IMapper mapper) : base(dbContext)
    {
        _mapper = mapper;
    }

    public IEnumerable<FoodDto> GetAll()
    {
        var mappedResponse = _mapper.Map<List<Food>, List<FoodDto>>(Entities.ToList());
        
        return mappedResponse;
    }

    public FoodDto GetById(int id)
    {
        var entity = Entities.FirstOrDefault(x => x.Id == id);

        var mappedResponse = _mapper.Map<Food, FoodDto>(entity);

        return mappedResponse;
    }

    public void Create(FoodDto request)
    {
        var mappedEntity = _mapper.Map<FoodDto, Food>(request);
        
        Insert(mappedEntity);
        Commit();
    }

    public void Edit(FoodDto request)
    {
        var mappedEntity = _mapper.Map<FoodDto, Food>(request);

        Update(mappedEntity);
        Commit();
    }

    public void Delete(int id)
    {
        Remove(id);
        Commit();
    }
}