using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace VitallyVeg.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Cuisine { get; set; }
        public List<string> Ingredients { get; set; }
        public string Time { get; set; }
        public int Yield { get; set; }
        public string Instructions { get; set; }
    }
}