using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExamples
{
    public class OddEvenPrime
    {
        public string GetPrintOut(int num)
        {
            if(num == 1 || num == 0)
            {
                return "SPECIAL CASE";
            }
            
            if( num == 2)
            {
                return "PRIME";
            }
            //A number is prime if it is Odd and only divisble by 1 and itself
            if (num % 2 == 0)
            {
                return "EVEN";
            }
            else
            {
                bool IsPrime = true;
                for(int i = 3; i <num; i += 2)
                {
                    if(num % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }

                if (IsPrime == false)
                {
                    return "ODD";
                }
                else
                {
                    return "PRIME";
                }
            }
        }
    }
}
