using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompistionExample.Attacks
{
    //We use this class if we want our character to always do the same amount of damage
    class FlatAttack : IAttack
    {
        int damage = 0;
        public FlatAttack(int damage)
        {
            this.damage = damage;
        }
        public int Attack()
        {
            return damage;
        }
    }
}
