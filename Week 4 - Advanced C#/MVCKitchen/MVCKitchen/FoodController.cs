using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCKitchen
{
    //When first looking at an MVC, check the controllers 
    class FoodController
    {
        //This will be our food "database", we'll learn databases and how to connect to C# later on
        public List<Food> FoodDB { get; set; } = new List<Food>();

        public FoodController()
        {
            FoodDB.Add(new Food() { Name = "Carrot", Calories=30, FoodGroup="Vegtable", HasElectrolytes=false});
            FoodDB.Add(new Food() { Name = "Gatorade", Calories = 220, FoodGroup = "Fruit", HasElectrolytes = true });
            FoodDB.Add(new Food() { Name = "Bread", Calories = 100, FoodGroup = "Grain", HasElectrolytes = true });
            FoodDB.Add(new Food() { Name = "Steak", Calories = 350, FoodGroup = "Meat", HasElectrolytes = true });
            FoodDB.Add(new Food() { Name = "Lettuce", Calories = 5, FoodGroup = "Vegtable", HasElectrolytes = false });

            //MVC is plug n play, the app does not care where the models come from, just that they're in the right format

        }

        //Pass the list of products down to a products view, which print will print them. 
        //Method inside controllers are called actions, each view gets its own action
        public void Products()
        {
            FoodListView pv = new FoodListView(FoodDB);
            int index = pv.Display();
            Food f = FoodDB[index];

            //Next I want to redirect the food item to the display food action
            DisplayFood(f);
        }

        public void DisplayFood(Food f)
        {
            //Make a food view, pass the food to it, and display its properties
            FoodView fv = new FoodView(f);
            fv.Display();
        }
    }
}
