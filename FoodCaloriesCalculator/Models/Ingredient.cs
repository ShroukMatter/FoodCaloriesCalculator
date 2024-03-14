namespace FoodCaloriesCalculator.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }


        //Foreign Key 
        public int FoodId { get; set; }


        //Navigation Property
        public Food Food { get; set; }
    }
}
