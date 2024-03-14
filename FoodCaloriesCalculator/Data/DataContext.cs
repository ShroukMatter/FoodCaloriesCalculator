using FoodCaloriesCalculator.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodCaloriesCalculator.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Food> Food { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relations between tables
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ingredient>()
                .HasOne(I => I.Food)
                .WithMany(F => F.ingredients)
                .HasForeignKey(I => I.FoodId);
        }


    }
}
