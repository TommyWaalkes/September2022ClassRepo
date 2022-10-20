using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class FactorialExample
    {
        public int GetFactorial(int total, int i, int endNum)
        {
            //1) Run your task
            //2) Check if you should end, if yes return total, if no call the method and return that call

          
            total *= i;

            if(i >= endNum)
            {
                return total;
            }
            else
            {
                i++;
                return GetFactorial(total, i, endNum); 
            }
        }
    }
}
