using AutoMapper;
using RestaurantAPI.DataLayer;
using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Entities;
using RestaurantAPI.DataLayer.Repositories.Restaurants;

namespace RestaurantAPI.BusinessLayer.Restaurants;

public class RestaurantService : RestaurantRepository, IRestaurantService
{
    private readonly IMapper _mapper;

    public RestaurantService(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
    {
        _mapper = mapper;
    }

    public IEnumerable<RestaurantDto> GetAll()
    {
        var mappedResponse = _mapper.Map<List<Restaurant>, List<RestaurantDto>>(Entities.ToList());

        return mappedResponse;
    }

    public RestaurantDto GetById(int id)
    {
        var entity = Entities.FirstOrDefault(x => x.Id == id);

        var mappedResponse = _mapper.Map<Restaurant, RestaurantDto>(entity);

        return mappedResponse;
    }

    public void Create(RestaurantDto request)
    {
        var mappedEntity = _mapper.Map<RestaurantDto, Restaurant>(request);

        Insert(mappedEntity);
        
        Commit();
    }

    public void Edit(RestaurantDto request)
    {
        var mappedEntity = _mapper.Map<RestaurantDto, Restaurant>(request);

        Update(mappedEntity);
        
        Commit();
    }

    public void Delete(int id)
    {
        Remove(id);
        Commit();
    }
}