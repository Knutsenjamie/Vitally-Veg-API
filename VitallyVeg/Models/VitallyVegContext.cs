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
                RecipeId: 2,
                Name: "Fluffy Vegan Yeast Donuts",
                Category: "Desserts",
                Cuisine: "American",
                Ingredients []: {"FOR DONUT DOUGH: 1/2 Cup Warm Water (110°F-115°F), 2 1/4 Tsp Yeast Active Dried Yeast or 1 Packet Active Dried Yeast, 1/4 Cup + 1 Tsp Organic White Sugar, 3/4 Cup Unsweetened Oat, Cashew, Coconut, or Soymilk (You want a thicker and creamier non-dairy milk for this recipe), 1/2 Cup Melted Vegan Butter, 1/4 Cup Vegan Sour Cream -OR- Unsweetened Vegan Yogurt, 3/4 Tsp Salt, 4 1/2 Cups Unbleached Organic All-Purpose Flour, High-Heat Oil (For frying; I used canola) FOR VANILLA GLAZE: 1 Cup Organic Vegan Powdered Sugar, 2 Tbsp Unsweetened Non-Dairy Milk, 1 Tbsp Mexican Vanilla or Pure Vanilla Extract FOR CHOCOLATE FROSTING: 1 Cup Organic Vegan Powdered Sugar, 2 Tbsp Vegan Butter, 4 Tbsp Vegan Cocoa Powder (Sieved), 1 Tsp Pure Vanilla Extract, 1/4 Cup Vegan Non-Dairy Milk, Vegan Colored Sprinkles (Optional) FOR JELLY FILLED: 1 Cup Organic Vegan Powdered Sugar, 11-12 Oz Jar Vegan Raspberry Jam (Seedless or seeded is fine depending on preference), Piping Tool -or- Piping Bag"},
                TotalTime: "3 Hours",
                Yield: 12,
                Instructions: "1. In a small bowl or glass liquid measuring cup, whisk warm water, 1 tsp of sugar, and yeast until well-combined. Set aside for 5 minutes or until yeast water becomes frothy and a visible layer has appeared on top of the water. 2. Next, whisk melted butter, vegan sour cream, non-dairy milk, and 1/4 cup white sugar. Then, whisk in activated yeast sugar water. Then, careful dump 4 1/2 cups flour into the wet mixture and the salt on top of the flour. Mix with a spatula until everything is well-combined and a sticky dough has formed. 3. Flour a clean surface, and turn the dough out onto it. Flour the top of the dough and your hands, and knead the dough for 3-5 minutes or until dough becomes smooth and shiny- but still slightly sticky. Form into a ball. Grease a large bowl, and place the ball of dough into the bowl. Cover with a clean tea towel, and place the bowl in a warm place. Let the dough rise for 1 1/2- 2 hours or until dough has doubled in size. 4. While dough is rising, prepare what options you want to have for your donut toppings. For the vanilla glaze, simply whisk everything together in a medium sized bowl and set aside. For chocolate frosting, simply whisk everything together minus the sprinkles until a thick frosting forms. Add more non-dairy milk tbsp by tbsp if too thick, and add more powdered sugar tbsp by tbsp if too thin. The texture should be like a regular chocolate butter cream. For the jelly filled, fill your piping bag with jam. Then, put 1 cup powdered sugar in a medium sized bowl. Refrigerate glaze, frosting, and jam before use. Cover the powdered sugar for the jelly filled option until use. 5. After dough has risen, punch it down to release gases. Then, flour a clean surface again and roll out the dough into a 1″ inch slab. Using a donut cutter, or a biscuit cutter and a small tool (like a test tube or a mini shot glass), cut out 12-14 regular donuts or just use a biscuit cutter without a small tool to make the filled donut option. If making all the options, cut 8 regular donut shapes and 4 jelly-filled donut shapes. I made mine to have 4 of each type. Once dough is all used up and donuts are cut into desired shapes, place donuts on two large baking sheets (6 on each) and cover both with tea towels to rest for another 25-30 minutes. 6. While donuts are proofing, grab a large stockpot or dutch oven. Fill your pot 1/2 way up with frying oil. Carefully heat your oil on high until it is 360°F-375°F Max. Use a thermometer to regulate the oils temperature between those two temps to prevent any accidents or burnt donuts. 7. Once donuts have proofed we are going to mis en place. Grab a set of metal tongs or a metal spider, grab 2 cooling racks and place them on top of a cutting board or grab two large baking sheets and cover them with paper towels for draining the excess oil off of the donuts. Have a fire extinguisher nearby to practice good kitchen safety in case of an accident. Lastly, have all of your toppings of choice/ fillings nearby. 8. After mis en placing, get ready to fry! GENTLY Place up to 3 donuts in the oil to fry at a time, being sure not to burn yourself or splash hot oil. We don’t want anyone to get hurt! Fry the donuts for 3-5 minutes on each side, or until light golden brown and cooked all the way through. Once done, set on cooling racks to drain or on lined baking sheets. You’ll want to wait at least 3 minutes after donuts are out of the fryer before you start handling them for decorating/filling. For vanilla glazed donuts, simply dunk either side of a warm donut into glaze until thoroughly coated, then set on cooling rack to dry for at least 20 minutes for glaze to harden. After that, enjoy! For the chocolate frosted donuts, you’ll want to wait at least 10 minutes before frosting- otherwise it’ll melt off! After 10 minutes, simply spread on chocolate frosting and top with sprinkles. Cool to set for at least 20 minutes. For the raspberry filled option, wait 3 minutes before handling. Take your piping bag and carefully plunge the metal tip into the bottom center of the donut, making sure not to penetrate the other side, and filling with raspberry jam as you come back out. Be sure to not over fill the donuts otherwise the jam could all fall out! Then, toss the donuts into the powdered sugar until thoroughly coated. Repeat these processes of choice until all donuts are fried and decorated. Once done, enjoy right away or seal in an air-tight container for up to 2 days. Enjoy!"
            },

            new Recipe 
            {
                RecipeId: 3,
                Name: "Tofu & Avocado Fresh Rolls Two Different Ways",
                Category: "Lunch",
                Cuisine: "Asian Inspired",
                Ingredients [] : {"2 12.3 Oz Packages Extra Firm Tofu; pressed, drained, and cut into 1-2″ inch strips, 1 14 Oz Container Spicy Vegan Kimchi, 6 Oz Package Saifun or Thin Rice Noodles; cooked according to package directions, then cooled., 2 4.7 Oz Packages of Rice Paper/Spring Roll Wrappers, 2 Large Carrots; julienned (matchstick cut), 3 Heads of Romaine or Green Leaf Lettuce; washed and cut in half, 3 Oz Package Thai Basil (regular works as well if that is all you can find), 3 Large Avocado; cut into slices, 1 Bunch Cilantro; roughly chopped., 3 Cups High-Heat Handling Oil (like canola, peanut, etc. that can handle frying), Salt & Freshly Ground Black Pepper to taste, Vegan Peanut Sauce -or- Sweet Chili Sauce (for dipping)"},
                TotalTime: "40 Minutes",
                Yield: 30,
                Instructions: "1. In a dutch oven or medium stockpot, add in three cups of high-heat oil and turn on heat to high. Grab a large mixing bowl, line with paper towels, and set aside. Go back to your heating oil on the stove, take a thermometer, and temp the oil until it is 350°F. Once Oil is 350°F, turn heat down to medium and begin frying tofu in batches, turning frequently so that each side becomes golden brown (about 3-5 minutes). Season the tofu in the mixing bowl after frying each batch. Once all tofu is fried and seasoned in the mixing bowl, set aside to cool. 2. If you haven’t already, cook your saifun/rice noodles- following package directions to make sure you do not over cook them. Once cooked, drain the noodles in a colander, and rinse them thoroughly with cold water to help them cool faster. Drain thoroughly and set aside in a medium sized bowl. 3. Now, you’ll want to prep all of your veggies if you haven’t already. Once everything is cut and prepped, mise en place so that you have something like an assembly line. Grab a large metal mixing bowl and fill it halfway with hot water so we can soak the rice paper to prepare the rolls. If your water starts to get cold overtime, just dump it out and refill it again with hot water. If it is too cold it won’t soften the rice paper easily- making the rolling process unnecessarily hard! Set this large bowl of hot water near the start of your assembly line. I suggest getting someone to help you roll these so the process goes faster; so I grabbed two cutting boards for each of us to roll on. 4. Once you have everything set up, begin by grabbing two sheets of rice paper/spring rolls wrappers. Soak each sheet one at a time for 1 minute in the hot water. Then, shake off any excess water and place the sheets directly on top of each other. Iv’e noticed that one sheet is too thin, so that is why we are double stacking the sheets in order to more securely wrap the ingredients. 5. Let’s start by making a kimchi roll. First, take a 1/2 lettuce leaf, or take two lettuce leaves if they are small, and lay them down flat in the center of the moist rice paper. Then, grab a little bit of rice noodles, a few carrot shreds, 2-3 slices of avocado, a tbsp or so of cilantro leaves, 2 strips of tofu, and about 2 tbsp of kimchi. Try to layer everything inside the lettuce leaf and think of the lettuce as a little wrapper in itself. It makes the rolling process much easier when everything is tucked neatly inside the lettuce leaf! Then, simply take the rice paper wrapper on the right, fold it in a couple centimeters, then take the left side and fold it in a couple centimeters as well. Finally, take the bottom flap of the roll and roll it forward like you would a burrito- tightly to make sure everything is secure. That's it! 6. Next, to make the regular tofu and avocado rolls, you’ll want to take the 1/2 lettuce leaf or two leaves just as you would in the kimchi roll and lay them in the center. Then, grab a little bit of rice noodles, carrot shreds, about 2-3 avocado slices, 2-4 basil leaves depending on the size, about a tbsp of cilantro leaves, and about 2 strips of fried tofu. Wrap it exactly how you did for the Kimchi Rolls. 7. Once you have used all of your ingredients and made an even amount of each roll, serve immediately with either peanut sauce or sweet chili sauce, or refrigerate these in an air-tight container for the next day. These start to slightly harden over time, so I’d definitely only keep them 1 day later at most. Enjoy!"
            },

            new Recipe 
            {
                RecipeId: 4,
                Name: "Tofu & Veggie Udon Noodle Stir-Fry",
                Category: "Dinner",
                Cuisine: "Asian Inspired",
                Ingredients [] : {"1.8 Lbs Vegan Udon Noodles, 2 Stocks Baby Bok Choy, 1 Cup Broccoli -OR- Cauliflower, 1 Cup Shiitake Mushrooms, 1/2 Cup Yellow Onions, 1/4 Cup Carrots, 1 Tsp Fresh Ginger, 3 Cloves Garlic, 1/4 Cup Soy Sauce -OR- Tamari, 1 Tbsp Vegan Oyster Sauce, 1 Tbsp Organic Vegan Brown Sugar, 3/4 Cup Veggie Broth -OR- Vegan Chicken Broth, 2 Tbsp Sesame Oil, 1 16 Oz Package PRESSED Extra-Firm Tofu, 1/4 Cup Neutral Oil (I used vegetable), Salt And Freshly Ground Black Pepper To Taste, Green Onion Stalk, Sliced Small (For garnish; optional)"},
                TotalTime: "40 Minutes",
                Yield: 4,
                Instructions: "1. We are going to start with the sauce. In a small mixing bowl, whisk together soy sauce, vegan oyster sauce, brown sugar, and sesame oil. On a cutting board, dice 3 cloves garlic and skin and dice 1 tsp of fresh ginger. Whisk the garlic and ginger into the sauce. Set Aside. 2. On a large cutting board, cut baby bok-choy and broccoli into bite-sized pieces. Then, Julienne cut the carrots, and slice the mushrooms and onion lengthwise into medium-sized slices. Set the cut veggies aside. 3. Next, take pressed tofu and drain. On a cutting board, cube the tofu into 1″inch pieces. Set aside. 4. In a large wok or skillet, heat half of the 1/4 cup of neutral oil to medium-high. Once oil is hot, stir fry the cubed tofu on medium-high heat until golden brown on all sides (about 3-5 minutes). Add salt and freshly ground black pepper to taste. Once tofu is cooked, turn down heat to medium and using a slotted spoon or spider, take tofu out of wok/skillet and place it onto a paper-towel lined plate or bowl to drain excess oil. Set aside. 5. Next, add the rest of the 1/4 cup of oil. The wok/skillet should still be heated to medium heat. Add all of the cut vegetables to the hot pan, and stir fry for 3-5 minutes or until veggies are almost tender but not all the way cooked. Then, add half of the sauce we made, half of the 3/4 cup of veggie/vegan chicken broth, and add all of the udon noodles. Bring the heat to medium-high, and let the noodles and veggies simmer in the sauce and broth, stirring and bringing the veggies on top of the noodles often. Cook for 3-5 minutes or until sauce and broth have evaporated, and noodles are halfway cooked. Add the rest of the broth, and continue cooking for 3-5 more minutes, repeating the process of bringing the veggies to the top and cooking the noodles on the bottom in the broth. Once the broth has evaporated this time, the noodles should be fully cooked. Turn off heat, and toss in cooked tofu. The residual heat should make the tofu hot again. Taste the udon stir-fry for salt and freshly ground black pepper, and add to taste if need be. Serve hot and garnish with green onion slices. Enjoy!"
            },

            new Recipe
            {
                RecipeId: 5,
                Name: "Vegan Style Fair Scones",
                Category: "Desserts",
                Cuisine: "European",
                Ingredients [] : {"1 Stick (1/2 Cup) COLD Vegan Butter; cut into tbsp-sized pieces, 2 3/4 Cup Organic Unbleached All-Purpose Flour, 1 Tbsp Baking Powder, 1/4 Cup Cornstarch, 2 Tbsp Organic White Sugar, 1/2 Tsp Salt, 3/4 Cup Non-Dairy Milk (I used oat), 1/2 Tsp Of Pure Vanilla Extract, Raspberry Jam (For serving), More Vegan Butter (For serving)",
                TotalTime: "35 Minutes"},
                Yield: 8,
                Instructions: "1. Preheat oven to 400°F. 2. In a large bowl, whisk together 2 3/4 Cups flour, baking powder, salt, sugar, and cornstarch until well-combined. 3. Next, using a pastry cutter or two forks, cut the cold vegan butter into the dry mixture until the butter is mixed evenly through-out into pea-sized pieces. We want these little butter pieces so that the scones have those flaky and buttery air pockets through-out! 4. After that, pour in non-dairy milk of choice, and vanilla extract. Combine the dough with a rubber spatula spatula until everything has just come together. It should be sticky, floury, and pretty messy! 5. Next, flour a clean and open surface. Bring the scone dough out onto the floured surface and kneed for roughly 1-2 minutes or until dough forms a smooth ball. Then, slightly flatten the dough into a round disk. Take a dough cutter or knife, and outline the top of the dough into 8 even-sized triangles. After outlining the dough, cut the dough on the outline until you have 8 even-sized triangles of scone dough. 6. Grab a large baking sheet, and either spray to grease or line with baking paper. Set scones evenly spaced apart. Bake for 12-15 minutes or until bottoms are golden brown and insides are cooked. Let cool for 3 minutes, then serve warm with fresh raspberry jam and vegan butter. Enjoy!"
            },

            new Recipe
            {
                RecipeId: 6,
                Name: "Vegan Jackfruit Pozole Verde",
                Category: "Dinner",
                Cuisine: "Latin American/Mexican",
                Ingredients [] : {"2 20 Oz Cans Young Jackfruit In Brine; Rinsed & Drained, 1 30 Oz Can White Hominy; Rinsed & Drained, 1 Lb Tomatillos (About 6-8), 2 Jalapeños, 3 Poblano Peppers, 1 Large Bunch Cilantro, 5-6 Cloves of Garlic, 1 Medium Yellow Onion, 8 Cups Chickenless or Veggie Broth, 1/4 Cups Neutral Oil ( 2 Tbsp + 2 Tbsp; I Used Canola),1/2 Tbsp Garlic Powder, 1 Tbsp Mexican Oregano, 1 Tsp Ground Cumin, Salt & Fresh Ground Pepper To Taste, Avocado Slices (Optional; For Garnish), Radish Slices (Optional; For Garnish), Lime Wedges (Optional; For Garnish), Chopped Cilantro (Optional; For Garnish), More Jalapeño; Sliced Thin (Optional; For Garnish)"},
                TotalTime: "2 Hours and 40 Minutes",
                Yield: 8,
                Instructions: "1. Preheat oven to 425°F. Grab a medium sized sheet pan and rinsed and drained jackfruit. Put the jackfruit directly onto the sheet pan, and add 2 Tbsp of oil, garlic powder, salt, and fresh ground pepper to taste. Then, massage and break up the pieces of jackfruit until they resemble shredded meat and so the seasoning and oil is distributed evenly. Once oven is at 425°F, bake jackfruit for 35-40 minutes- flipping the jackfruit halfway through the baking process. Once jackfruit is slightly browned and has some crispy edges, it’s done. Set aside to cool. 2. Next, preheat oven to broil at 500°F. While oven is preheating, remove the husks from and wash tomatillos. Then, grab a large cast iron skillet or sheet pan. Place tomatillos, poblanos, and jalapeños on pan. Broil the chilis and tomatillos for 20 minutes, flipping halfway, until the veggies are slightly charred. Set aside to cool. 3. Grab a medium sized cutting board, and dice the medium yellow onion. Then, finely mince the garlic cloves. Once chili’s are cooled, peel and discard the skin off of the poblano peppers and jalapeños and deseed the poblanos. if you want it less spicy, deseed the jalapeños as well. Set aside. 4. Grab a large stockpot or dutch oven. Then, add 2 Tbsp of oil and heat to medium-high. Once oil is hot, add the minced garlic and HALF of the diced onion. Then, Sprinkle in the cumin and oregano and sauté the veggies and spices until onion is translucent and garlic and spices are fragrant. Next, pour in half of the chickenless or veggie broth and turn off heat. Then, add large bunch of cilantro, roasted tomatillos, poblanos, and jalapeños to the pot. Grab an immersion blender or high powered blender that can handle hot liquid, and blend the soup on high until smooth. Add the soup back into the stockpot (or don’t since you don’t have to if you used an immersion blender; lol) and turn heat on to medium high. Add in the rest of the stock, diced onion, drained and rinsed Hominy, and baked jackfruit into the pot. Once the soup starts to boil, reduce the heat to simmer and simmer the soup for about 2 hours for flavors to develop. After that, salt and pepper to taste, stir, and it’s ready to serve! Garnish with fresh jalapeño slices (for more heat), sliced radishes, chopped cilantro, lime wedges, and sliced avocado. Enjoy!"
            },

            new Recipe
            {
                RecipeId: 7,
                Name: "Vegan Potato & Poblano Tacos With Chipotle Aioli",
                Category: "Dinner",
                Cuisine: "Latin American/Mexican",
                Ingredients [] : {"1 Lb 8 Oz Baby Potatoes, Yukon Gold Potatoes, or Red Potatoes., 2 Poblano Peppers, 3 Cloves of Garlic, 1/4 Cup Neutral Oil, 1 Tbsp Chili Powder, 1 Tsp Garlic Powder, 1/2 Large Lime (Sliced for Garnish), Slaw (For Garnish), Cilantro (For Garnish), Tortillas Of Choice For Serving, Salt & Pepper To Taste. FOR THE CHIPOTLE AIOLI: 1 1/2 Cups Vegan Mayo, 4-6 Chipotle Peppers In Adobo (From a Can), 1/2 A Lime; Juiced, Salt And Pepper To Taste"},
                TotalTime: "50 Minutes",
                Yield: 8,
                Instructions: "1. Preheat oven to 375°F 2. On a large cutting board, cut poblano peppers and onions into small strips. Then, cut potatoes into bite sized pieces. Lastly, mince your 3 cloves of garlic. Set aside. 3. Then, grab a large sheet/baking pan. Add your strips of poblano, onions, minced garlic, and the cut potatoes. Add the 1/4 cup of neutral oil, chili powder, garlic powder, and salt and pepper to taste. Massage the spices and oil into the veggies on the sheet pan until well-coated. 4. Once oven is preheated, bake @ 375°F for 25-30 minutes. 5. While the taco filling is roasting, make the chipotle aioli. In a medium-large food processor, add the vegan mayo, chipotle peppers in adobo, salt and pepper to taste, and juice of the 1/2 a lime. Blend on high until smooth. Refrigerate until tacos are ready to serve. 6. Once tacos are done, switch oven to broil @ 400°F and cook for another 2 minutes or until potatoes are golden brown. After that, they’re done! 7. Serve in hot tortillas of choice with slaw, fresh chopped cilantro, drizzle of chipotle aioli, and lime wedges!"
            },
        



        );