using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCKitchen
{
    class FoodListView
    {
        public List<Food> Foods { get; set; }

        public FoodListView(List<Food> Foods)
        {
            this.Foods = Foods;
        }

        public int Display()
        {
            //The job of this display is to interact with our front-end aka the console 
            Console.WriteLine("Welcome to our Food App");
            for(int i = 0; i < Foods.Count; i++)
            {
                Food food = Foods[i];
                Console.WriteLine(i+" : "+food.Name);
            }

            Console.WriteLine("Which food item would you like to view? (Select by index)");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            return index;
        }
    }
}
