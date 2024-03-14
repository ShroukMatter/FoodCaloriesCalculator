using FoodCaloriesCalculator.DTO;
using FoodCaloriesCalculator.Interfaces;
using FoodCaloriesCalculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodCaloriesCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodRepository _foodRepository;
        public FoodController(IFoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }
        [HttpGet]
        public IActionResult GetFoods()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var foods = _foodRepository.GetFoods();

            if (foods == null)
            {
                return NotFound();
            }

            var foodDtos = foods.Select(food => new FoodDto
            {
                Id = food.Id,
                Food = food.Name,
                Ingredients = food.ingredients.Select(i => i.Name).ToList()
            }).ToList();

            return Ok(foodDtos);
        }

       
        [HttpGet("{foodId:int}")]
        public IActionResult GetFood(int foodId)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            else
            {
                Food food = _foodRepository.GetFood(foodId);
                FoodDto foodIngredientsDTO = new FoodDto()
                {
                    Id = foodId,
                    Food = food.Name,
                    Ingredients = food.ingredients.Select(I => I.Name).ToList()
                };
                return Ok(foodIngredientsDTO);
            }
        }
        [HttpGet("{foodName:alpha}")]
        public IActionResult GetFoodByName(string foodName)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(_foodRepository.GetFood(foodName));
        }



        /*[HttpPost]
        public IActionResult CreateFood(Food food)
        {
            if (food == null)
                return BadRequest(ModelState);
            else
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                Food food = new Food()
                {
                    Name = foodDto.Food
                }
                return Ok(_foodRepository.CreateFood(food));
            }

        }*/
    }
}
