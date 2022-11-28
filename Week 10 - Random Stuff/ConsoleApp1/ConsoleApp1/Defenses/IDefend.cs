using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompistionExample.Defenses
{
    internal interface IDefend
    {
        //We want this method to return an int in order to return the reduced damage number
        //This class cannot modifying the character's HP, that job is on the character 

        //Put another way, the only job of this interface is calculating damage reduction 
        //HP is the job of the character class
        public int Defend(int damage);
    }
}
