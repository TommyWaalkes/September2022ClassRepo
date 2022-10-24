using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDAndFizzBuzz
{
    internal class FizzBuzz
    {
        public string ReturnFizzBuzz(int num)
        {
            if(num % 3 == 0 && num % 5 == 0)
            {
                return "fizzbuzz";
            }

            if (num % 3 == 0)
            {
                return "buzz";
            }
            else if(num % 5 == 0)
            {
                return "fizz";
            }
            else
            {
                return "";
            }
        }
    }
}
