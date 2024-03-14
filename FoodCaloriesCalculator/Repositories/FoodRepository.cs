using FoodCaloriesCalculator.Data;
using FoodCaloriesCalculator.Interfaces;
using FoodCaloriesCalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodCaloriesCalculator.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly DataContext _context;
        public FoodRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Food> GetFoods()
        {
            return _context.Food.Include(F => F.ingredients).ToList();
        }

        public Food GetFood(int id)
        {
            return _context.Food.Include(F => F.ingredients).Where(F => F.Id == id).FirstOrDefault();
        }

        public Food GetFood(string name)
        {
            return _context.Food.Where(F => F.Name == name).FirstOrDefault();

        }

        public bool CreateFood(Food food)
        {
            _context.Food.Add(food);

            return Save();

        }

        public bool UpdateFood(Food food)
        {
            _context.Food.Update(food);
            return Save();
        }



        public bool Save()
        {
            return _context.SaveChanges() > 0 ? true : false;
        }

        
    }
}
