using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    //With inheritance, you want to make your parent class first, it dictates what each child will look like
    public class Animal
    {
        public int CaloriesNeeded { get; set; }

        //What is up with this variable? 
        //This create what's a called a listener on that condition
        //It listens changes to either calorie property and updates IsSated based upon the boolean condition
        //This is another use for lambda expressions outside of linq 
        //This is a trick unique to C# 
        public virtual bool IsSated => CaloriesConsumed >= CaloriesNeeded;
        
        //Assume the animal has yet to eat today 
        public int CaloriesConsumed { get; set; } = 0;

        //A Virtual  method means the child has the option of overriding this method. 
        //If the child does not override the method, then the child gets it as is
        public virtual void Eat(string FoodType, int calories)
        {
            CaloriesConsumed += calories; 
        }
    }
}
