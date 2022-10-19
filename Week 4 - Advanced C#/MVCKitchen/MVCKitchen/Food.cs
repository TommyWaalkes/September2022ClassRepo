using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCKitchen
{
    //Food only represents its data, no functionality unrelated to data should go here 
    //Most of the time Models are just a series of properties
    class Food
    {
        public string Name { get; set; }
        public string FoodGroup { get; set; }
        public int Calories { get; set; }
        public bool HasElectrolytes { get; set; }
    }
}
