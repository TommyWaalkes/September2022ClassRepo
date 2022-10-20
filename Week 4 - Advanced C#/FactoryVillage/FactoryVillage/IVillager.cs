using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryVillage
{
    internal interface IVillager
    {
        public int Hunger { get; set; }
        public int HP { get; set; }
        public int FarmingOutput { get; set; }
        public int Farm();
    }
}
