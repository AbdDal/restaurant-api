using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.BusinessLayer.Menus;
using RestaurantAPI.DataLayer.Dtos;

namespace RestaurantAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class MenuController : ControllerBase
{
    private readonly IMenuService _menuService;

    public MenuController(IMenuService menuService)
    {
        _menuService = menuService;
    }
    
    // GET
    [HttpGet]
    public ActionResult<IEnumerable<MenuDto>> GetAll()
    {
        var menus = _menuService.GetAll();

        if (!menus.Any())
        {
            return NoContent();
        }
        
        return Ok(menus);
    }

    [HttpGet("{id}")]
    public ActionResult<MenuDto> GetById(int id)
    {
        var menu = _menuService.GetById(id);

        if (menu == null)
        {
            return NotFound();
        }

        return Ok(menu);
    }

    [HttpPost]
    public ActionResult Create([FromForm] MenuDto request)
    {
        _menuService.Create(request);

        return Ok();
    }
    
    [HttpPut]
    public ActionResult Edit([FromForm] MenuDto request)
    {
        _menuService.Edit(request);

        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _menuService.Delete(id);

        return Ok();
    }
}