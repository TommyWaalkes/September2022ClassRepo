using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCKitchen
{
    class FoodView
    {
        //This has one job, get a food model and print its properties 
        Food Food { get; set; }

        public FoodView(Food Food)
        {
            this.Food = Food;
        }

        public void Display()
        {
            Console.WriteLine("Food Display:");
            Console.WriteLine("Name: "+ Food.Name);
            Console.WriteLine("Food Group: "+Food.FoodGroup);
            Console.WriteLine("Calories: " + Food.Calories);
            Console.WriteLine("Electrolytes: "+ Food.HasElectrolytes);
        }
    }
}
