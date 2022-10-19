using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    //Subclassing an interface is the same as concrete and abstract classes 
    //Many language will want you to use the implements keyword 
    internal class Deer : IAnimal
    {
        //I know all animals will need calories eaten and needed, but all children MUST supply their own values
        //Interface parents may not share functionality between classes
        public int CaloriesNeeded { get; set; } = 1200;
        public int CaloriesEaten { get; set; } = 0; 


        //Override an interface method does not use the override keyword 
        public void Eat(string foodType, int amount)
        {
            if(foodType == "plant")
            {
                CaloriesEaten += amount;
            }
        }

        public bool IsSated()
        {
            return CaloriesNeeded <= CaloriesEaten;
        }
    }
}
