namespace FoodCaloriesCalculator.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double ServingSize { get; set;}


        //Navigation Property
        public List<Ingredient> ingredients { get; set; }

    }
}
