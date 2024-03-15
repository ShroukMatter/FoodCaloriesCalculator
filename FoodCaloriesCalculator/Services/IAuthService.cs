using FoodCaloriesCalculator.Models;

namespace FoodCaloriesCalculator.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}
