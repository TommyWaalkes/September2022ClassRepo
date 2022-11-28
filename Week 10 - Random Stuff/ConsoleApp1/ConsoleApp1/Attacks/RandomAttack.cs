using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompistionExample.Attacks
{

    //We use this method if we wish the character to have a random damage for their attacks. 
    class RandomAttack : IAttack
    {
        int minDamage = 1;
        int maxDamage = 2;

        public RandomAttack(int minDamage, int maxDamage)
        {
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public int Attack()
        {
            Random r = new Random();
            int damage = r.Next(minDamage, maxDamage + 1);
            return damage;
        }
    }
}
