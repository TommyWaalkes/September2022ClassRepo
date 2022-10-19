using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    internal abstract class Villager
    {
        public int Hunger { get; set; }

      
        public abstract int Farm();
    }
}
