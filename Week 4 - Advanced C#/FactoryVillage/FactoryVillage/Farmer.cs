using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;

namespace FactoryVillage
{
    internal class Farmer : IVillager
    {
        public int Hunger { get; set; } = 1;
        public int HP { get; set; } = 3;
        public int FarmingOutput { get; set; } = 2;

        public int Farm()
        {
            return FarmingOutput;
        }
    }
}
