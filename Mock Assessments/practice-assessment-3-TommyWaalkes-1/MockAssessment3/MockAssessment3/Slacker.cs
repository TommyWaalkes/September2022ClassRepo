using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    internal class Slacker : Villager
    {
        public Slacker()
        {
            //Doing it in the constructor ensures all farmer have the same hunger value
            Hunger = 3;
        }

        public override int Farm()
        {
            return 0;
        }
    }
}
