using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    public class Panda : Animal
    {
        public Panda()
        {
            CaloriesNeeded = 3000;
        }

        public override void Eat(string FoodType, int calories)
        {
            if(FoodType == "plants")
            {
                CaloriesConsumed += calories / 2;
            }
        }
    }
}
