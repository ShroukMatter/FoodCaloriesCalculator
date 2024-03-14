using FoodCaloriesCalculator.Models;

namespace FoodCaloriesCalculator.Interfaces
{
    public interface IIngredientsRepository
    {
        ICollection<Ingredient> GetIngredients();

        Ingredient GetIngredient(int id);
        Food GetIngredient(string name);

        bool CreateIngredient(Food food);
        bool UpdateIngredient(Food food);
        bool Save();
    }
}
