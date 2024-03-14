using FoodCaloriesCalculator.Models;

namespace FoodCaloriesCalculator.Interfaces
{
    public interface IFoodRepository
    {
        ICollection<Food> GetFoods();

        Food GetFood(int id);
        Food GetFood(string name);

        bool CreateFood(Food food);
        bool UpdateFood(Food food);
         bool Save();





    }
}
