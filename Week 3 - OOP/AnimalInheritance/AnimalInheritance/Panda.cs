using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    public class Panda : Animal
    {
        //Pandas are slightly more complex than bush, 
        //You need to set the calories needed 
        //then override eat and halve the amount of calories input 
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
