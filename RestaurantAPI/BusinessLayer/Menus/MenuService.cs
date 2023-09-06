using AutoMapper;
using RestaurantAPI.DataLayer;
using RestaurantAPI.DataLayer.Dtos;
using RestaurantAPI.DataLayer.Entities;
using RestaurantAPI.DataLayer.Repositories.Menus;

namespace RestaurantAPI.BusinessLayer.Menus;

public class MenuService : MenuRepository, IMenuService
{
    private readonly IMapper _mapper;

    public MenuService(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext)
    {
        _mapper = mapper;
    }

    public IEnumerable<MenuDto> GetAll()
    {
        var mappedResponse = _mapper.Map<List<Menu>, List<MenuDto>>(Entities.ToList());
        
        return mappedResponse;
    }

    public MenuDto GetById(int id)
    {
        var entity = Entities.FirstOrDefault(x => x.Id == id);
        
        var mappedResponse = _mapper.Map<Menu, MenuDto>(entity);

        return mappedResponse;
    }

    public void Create(MenuDto request)
    {
        var mappedEntity = _mapper.Map<MenuDto, Menu>(request);
        
        Insert(mappedEntity);
        Commit();
    }

    public void Edit(MenuDto request)
    {
        var mappedEntity = _mapper.Map<MenuDto, Menu>(request);
        
        Update(mappedEntity);
        Commit();
    }

    public void Delete(int id)
    {
        Remove(id);
        Commit();
    }
}