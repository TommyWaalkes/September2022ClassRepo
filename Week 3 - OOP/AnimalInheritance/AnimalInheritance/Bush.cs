using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
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
