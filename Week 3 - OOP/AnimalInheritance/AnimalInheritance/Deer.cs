using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    //This sets Deer to be a child of animal 
    //Means that deer gets access to all nonprivate methods and properties from its parent
    class Deer : Animal
    {
        public Deer()
        {
            CaloriesNeeded = 1200;
        }

        //To override, use the override keyword and match the signature of the parent version 
        //IE same parameters, same return type, and same name
        public override void Eat(string FoodType, int calories)
        {
            if(FoodType == "Plants")
            {
                CaloriesConsumed += calories;
            }
        }
    }
}
