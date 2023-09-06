using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.BusinessLayer.Restaurants;
using RestaurantAPI.DataLayer.Dtos;

namespace RestaurantAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<RestaurantDto>> GetAll()
    {
        var restaurants = _restaurantService.GetAll();

        if (!restaurants.Any())
        {
            return NoContent();
        }
        
        return Ok(restaurants);
    }

    [HttpGet("{id}")]
    public ActionResult<RestaurantDto> GetById(int id)
    {
        var restaurant = _restaurantService.GetById(id);

        if (restaurant == null)
        {
            return NotFound();
        }

        return Ok(restaurant);
    }

    [HttpPost]
    public ActionResult Create([FromForm] RestaurantDto request)
    {
        _restaurantService.Create(request);

        return Ok();
    }

    [HttpPut]
    public ActionResult Edit([FromForm] RestaurantDto request)
    {
        _restaurantService.Edit(request);

        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _restaurantService.Delete(id);

        return Ok();
    }
}