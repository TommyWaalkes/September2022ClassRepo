using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompistionExample.Defenses
{
    //Use this if we want to take full damage on our character
    internal class NoDefense : IDefend
    {
        public int Defend(int damage)
        {
            //We take full damage no reduction 
            return damage;
        }
    }
}
