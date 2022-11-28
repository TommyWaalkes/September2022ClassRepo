using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompistionExample.Defenses
{
    internal class DodgeDefense : IDefend
    {
        public double DodgeChance { get; set; }

        public DodgeDefense(double dodgeChance)
        {
            DodgeChance = dodgeChance;
        }

        //Roll Randomly to see if we can completely negate damage. 
        public int Defend(int damage)
        {
           Random r = new Random();
            double dodgeRoll = r.Next(1,101);

            if (dodgeRoll <=DodgeChance )
            {
                damage = 0;
            }

            return damage;
        }
    }
}
