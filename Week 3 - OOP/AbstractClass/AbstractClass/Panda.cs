using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Panda : AbstractAnimal
    {
        public override bool IsSated => CaloriesNeeded <= CaloriesEaten;

        //: base after the constructor pass parameters that are required to the parent class
        public Panda(int CaloriesNeeded) : base(CaloriesNeeded)
        {
        }

        public override void Eat(FoodType foodType, int amount)
        {
            if(foodType == FoodType.Plants)
            {
                CaloriesEaten += amount / 2;
            }
        }
    }
}
