using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInheritance
{
    class Wolf : Animal
    {
        public int TimesFed { get; set; } = 0;

        //This is an example of adding onto the parent's is sated listener 
        //We call the base condition and then add onto it 
        //Like with methods you can either replace or add onto a lambda 
        public override bool IsSated => base.IsSated && TimesFed >= 4;
        public Wolf()
        {
            CaloriesNeeded = 800;
        }

        public override void Eat(string FoodType, int calories)
        {
            if(FoodType.ToLower() == "meat")
            {
                TimesFed++;
                CaloriesConsumed += calories;
            }
        }

    }
}
