using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    class Cat : Animal
    {
        public Cat()
        {
            CaloriesNeeded = 500;
        }
        public override void Eat(string FoodType, int calories)
        {
            //I want to use the parents version and add onto it
            //Most of the time its used to call the parents version of a method 
            //Base can also be used to call and feed data to the parent constructor, more on that 
            //Later on 
            base.Eat(FoodType, calories);
            Console.WriteLine("The cat is acting like he hasn't been fed");
            CaloriesConsumed = 0;
        }
    }
}
