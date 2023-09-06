using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.BusinessLayer.Foods;
using RestaurantAPI.DataLayer.Dtos;

namespace RestaurantAPI.Controllers;

[ApiController]
[Route("[Controller]")]
public class FoodController : Controller
{
    private readonly IFoodService _foodService;

    public FoodController(IFoodService foodService)
    {
        _foodService = foodService;
    }
    
    [HttpGet]
    public ActionResult<IEnumerable<FoodDto>> GetAll()
    {
        var foods = _foodService.GetAll();

        if (!foods.Any())
        {
            return NoContent();
        }
        
        return Ok(foods);
    }

    [HttpGet("{id}")]
    public ActionResult<FoodDto> GetById(int id)
    {
        var food = _foodService.GetById(id);

        if (food == null)
        {
            return NotFound();
        }

        return Ok(food);
    }

    [HttpPost]
    public ActionResult Create([FromForm] FoodDto request)
    {
        _foodService.Create(request);
        
        return Ok();
    }
    
    [HttpPut]
    public ActionResult Edit([FromForm] FoodDto request)
    {
        _foodService.Edit(request);
        
        return Ok();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        _foodService.Delete(id);
        
        return Ok();
    }
}