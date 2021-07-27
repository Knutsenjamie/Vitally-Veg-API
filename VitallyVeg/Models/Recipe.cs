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
        public string Ingredients { get; set; }
        public string Time { get; set; }
        public int Makes { get; set; }
        public string Instructions { get; set; }
    }
}