using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public enum FoodType
    {
        Meat, 
        Light, 
        Plants
    }

    //So you tell C# a class will be abstract by using the abstract keyword
    public abstract class AbstractAnimal
    {
        public int CaloriesNeeded { get; set; }
        public int CaloriesEaten { get; set; } = 0;
        public virtual bool IsSated { get; set; }

        public AbstractAnimal(int CaloriesNeeded)
        {
            this.CaloriesNeeded = CaloriesNeeded;
        }

        //Abstract methods have no bodies, children MUST fill them in themselves 
        public abstract void Eat(FoodType foodType, int amount);
    }
}
