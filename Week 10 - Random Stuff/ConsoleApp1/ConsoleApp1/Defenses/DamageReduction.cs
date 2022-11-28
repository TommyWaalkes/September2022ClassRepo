using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompistionExample.Defenses
{
    internal class DamageReduction : IDefend
    {
        public int Armor = 1;
        public DamageReduction(int armor)
        {
            Armor = armor;
        }

        //This reduces damage by armor, but not below 1
        public int Defend(int damage)
        {
            damage -= Armor; 

            if(damage <= 0) {
                damage = 1;
            }

            return damage;
        }
    }
}
