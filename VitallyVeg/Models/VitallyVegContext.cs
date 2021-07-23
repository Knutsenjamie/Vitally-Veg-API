using Microsoft.EntityFrameworkCore;

    namespace VitallyVeg.Models
    {
    public class VitallyVegContext : DbContext
    {
        public VitallyVegContext(DbContextOptions<VitallyVegContext> options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Recipe>()
        .HasData(
            new Recipe 
            {

                RecipeId = 1,
                Name: "Crispy Vegan Hot Fried Drumsticks",
                Category: "Appetizers",
                Cuisine: "American",
                Ingredients []: {"2 8.3 Oz Bags Vegan Smoked Drumsticks, 2 1/2 Cups Flour, 1/2 Tbsp Baking Powder, 1/2 Tsp Smoked Paprika, 1 Tsp Garlic Powder, 1 Tbsp Vegan Cajun Seasoning, 1 1/2 Tbsp Salt, 1/2 Tsp Freshly Ground Black Pepper, 1 Tbsp ACV or White Vinegar, 1-3 Tbsp Vegan Hot Sauce (Depending on spice preferance), 1 Cup Non-Dairy Milk (I used oat milk), Oil For Frying, Vegan Buttermilk Ranch (For dipping)"},
                TotalTime: "25 Minutes",
                Yield: 12,
                Instructions: "1. Start by defrosting your 2 8.3 Oz bags vegan smoked drumsticks if they are frozen. Once thawed, open the packages and pat the drumsticks dry with a paper towel on a plate. Set aside. 2. In a large mixing bowl, whisk together 2 1/2 cups flour, 1/2 tbsp baking powder, 1 tsp garlic powder, 1/2 tsp paprika, 1 tbsp vegan cajun seasoning, 1 1/2 tbsp salt, and 1/2 tsp freshly ground black pepper until well combined. Set aside. 3. Then, in a medium-sized mixing bowl, whisk together 1 cup non-dairy milk of choice, 1 Tbsp ACV or White Vinegar, and 1 Tbsp-3 Tbsp vegan hot sauce depending on how spicy you want your wings. Season to taste with salt. 4. Next, grab a clean plate, the plate of drumsticks, and the wet and dry ingredient bowls to set up your dredging station. With a pair of metal tongs, grab a dry drumstick, then coat it in flour mixture, then coat it in the wet mixture, and then repeat one more time until the drumstick is double-battered and their last coat is flour. Set on the clean plate. Repeat those steps until all the wings are double-battered and evenly covered in batter. Set aside. 5. Next, heat a large pot or dutch oven with at least 3-6 cups of a high-heat oil for frying to 390°F-400°F. Grab a plate and line it with paper towels to absorb excess oil and set it near your frying oil. Then, grab a clean set of tongs and the double-battered plate of drumsticks. Slowly release a drumstick into the hot oil gently and carefully until submerged. Quickly repeat until there are 4-5 drumsticks in the hot oil. Fry for 3-5 minutes, turning gently halfway with tongs to get even-coverage, until drumsticks are golden brown. Carefully use a spider tool or tongs to grab drumsticks out and place onto the paper-towel-lined plate to drain any excess oil. Repeat until all wings are fried. Be sure to turn off oil and handle it safely. 6. Once all the drumsticks are fried, you can optionally brush more hot sauce or even vegan buffalo sauce onto the outside with a bbq brush onto each drumstick if you want to bring even more heat. Serve drumsticks hot with vegan ranch or vegan blue cheese for dipping. Enjoy!"

            },

            new Recipe 

            {

            },




        );