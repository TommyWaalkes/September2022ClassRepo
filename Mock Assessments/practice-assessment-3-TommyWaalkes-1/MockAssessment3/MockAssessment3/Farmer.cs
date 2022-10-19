using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment3
{
    internal class Farmer : Villager
    {
        public Farmer()
        {
            //Doing it in the constructor ensures all farmer have the same hunger value
            Hunger = 1;
        }

        public override int Farm()
        {
            return 2;
        }
    }
}
