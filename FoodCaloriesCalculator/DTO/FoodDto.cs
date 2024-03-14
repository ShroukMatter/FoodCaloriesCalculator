namespace FoodCaloriesCalculator.DTO
{
    public class FoodDto
    {
        public int Id { get; set; }
        public string Food { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();
    }
}
