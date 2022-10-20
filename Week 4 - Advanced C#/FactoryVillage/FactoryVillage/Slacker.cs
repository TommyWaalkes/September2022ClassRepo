using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVillage
{
    internal class Slacker : IVillager
    {
        public int Hunger { get; set; } = 3;
        public int HP { get; set; } = 5;
        public int FarmingOutput { get; set; } = 1; 

        public int Farm()
        {
            return FarmingOutput;
        }
    }
}
