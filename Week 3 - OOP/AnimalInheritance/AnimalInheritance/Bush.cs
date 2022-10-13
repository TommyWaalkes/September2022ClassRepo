using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    //Bush needs 50 calories and only light
    //We only need to swap the calories variable and 
    //Override eat in small ways to make this work 
    public class Bush : Animal
    {
        public Bush()
        {
            CaloriesNeeded = 50;
        }

        public override void Eat(string FoodType, int calories)
        {
            if(FoodType.ToLower() == "light")
            {
                CaloriesConsumed += calories;
            }
        }

    }
}
