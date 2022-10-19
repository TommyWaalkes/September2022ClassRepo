using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    internal class Wolf : IAnimal
    {
        public int CaloriesNeeded { get; set; } = 800;
        public int CaloriesEaten { get; set; } = 0;
        public int TimesEaten { get; set; } = 0; 

        public void Eat(string foodType, int amount)
        {
           if(foodType == "meat")
            {
                CaloriesEaten += amount;
                TimesEaten++;
            }
        }

        public bool IsSated()
        {
            if (CaloriesNeeded <= CaloriesEaten && TimesEaten >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
