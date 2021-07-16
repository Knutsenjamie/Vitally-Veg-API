namespace VitallyVeg.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Cuisine { get; set; }
        public string Ingredients { get; set; }
        public int CookTime { get; set; }
        public int Yield { get; set; }
        public string Instructions { get; set; }
    }
}