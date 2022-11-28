using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompistionExample.Attacks;
using CompistionExample.Defenses;

namespace CompistionExample
{
    internal class Character
    {
        public int HP { get; set; }
        public IAttack AttackMethod { get; set; }
        public IDefend DefendMethod { get; set; }
        public bool IsAlive => HP > 0;

        //Composition injecting and delegating method calls to other classes 

        //This allows me to use any attack and any defense methods I wish 
        //I can customize my character without creating problems elsewhere in my code 
        //Each attack/defend has its own clear job
        public Character(IAttack attackMethod, IDefend defendMethod, int hP)
        {
            AttackMethod = attackMethod;
            DefendMethod = defendMethod;
            HP = hP;
        }

        public void Attack(Character target)
        {
            //delegate a call to our injected attack method 
            //We don't how it figures out damage just that it will return a damage number 
            int damage = AttackMethod.Attack();

            int dmgReduced = target.DefendMethod.Defend(damage);
            Console.WriteLine($"This character does {dmgReduced} to the opponent");
            target.HP -= dmgReduced;
        }


    }
}
