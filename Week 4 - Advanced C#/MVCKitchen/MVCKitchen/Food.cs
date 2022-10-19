using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCKitchen
{
    class Food
    {
        public string Name { get; set; }
        public string FoodGroup { get; set; }
        public int Calories { get; set; }
        public bool HasElectrolytes { get; set; }
    }
}
