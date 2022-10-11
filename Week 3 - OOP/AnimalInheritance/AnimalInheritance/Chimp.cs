using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    //Chimps will eat anything, but need 1000 calories and at least 200 meat calories. 
    public class Chimp : Animal
    {
        //This property is only available to chimp 
        //Parents only give to their children, but they don't recieve 
        public int MeatCalories { get; set; }

        //If you make a lambda virtual you can override and customize it in the child 
        //This is something only C# does
        public override bool IsSated => CaloriesConsumed >= CaloriesNeeded && MeatCalories >= 200;
        public Chimp()
        {
            CaloriesNeeded = 1000;
        }

        public override void Eat(string FoodType, int calories)
        {
            CaloriesConsumed += calories;

            if (FoodType.ToLower() == "meat")
            {
                MeatCalories += calories;
            }
        }

    }
}
