using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVillage
{
    internal class Fighter : IVillager
    {
        public int Hunger { get; set; } = 2;
        public int HP { get; set; } = 10; 
        public int FarmingOutput { get; set; } = 2;

        public int Farm()
        {
            return FarmingOutput / 2;
        }
    }
}
