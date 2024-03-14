using FoodCaloriesCalculator.Data;
using FoodCaloriesCalculator.Interfaces;
using FoodCaloriesCalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodCaloriesCalculator.Repositories
{
    public class IngredientRepository : IIngredientsRepository
    {
        private readonly DataContext _context;
        public IngredientRepository(DataContext context)
        {
            _context = context;
        }
        public bool CreateIngredient(Food food)
        {
            throw new NotImplementedException();
        }

        public Ingredient GetIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public Food GetIngredient(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Ingredient> GetIngredients()
        {
            return _context.Ingredients.ToList();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateIngredient(Food food)
        {
            throw new NotImplementedException();
        }
    }
}
