using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FoodCaloriesCalculator.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,MaxLength(50)]
        public String FirstName { get; set; }

        [Required, MaxLength(50)]
        public String LasttName { get; set; }

    }
}
