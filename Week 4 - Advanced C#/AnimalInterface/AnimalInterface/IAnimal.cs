using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    internal interface IAnimal
    {
        //I may have a property in an interface, but I may not give it values 
        //This is something only C# does.
        public int CaloriesNeeded { get; set; } 
        public int CaloriesEaten { get; set; }

        //This is a method stub and in most languages this is all thats allowed in an interface 
        //Children MUST fill in the body themselves 
        public void Eat(string foodType, int amount);

        public bool IsSated();
    }
}
