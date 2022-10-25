using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExamples
{
    public class NumsConverter
    {
        public string Convert(int num)
        {
           if(num <= 10)
            {
               return GetOnes(num);
            }
           else if(num < 20)
            {
                return GetTeens(num);
            }
           else if(num >= 20)
            {
                return GetTens(num);
            }

            return "";
        }

        public string GetOnes(int num)
        {
            if (num == 0)
            {
                return "zero";
            }
            else if (num == 1)
            {
                return "one";
            }
            else if (num == 2)
            {
                return "two";
            }
            else if(num == 3)
            {
                return "three";
            }
            else if (num == 4)
            {
                return "four";
            }
            else if (num == 5)
            {
                return "five";
            }
            else if (num == 6)
            {
                return "six";
            }
            else if (num == 7)
            {
                return "seven";
            }
            else if (num == 8)
            {
                return "eight";
            }
            else if (num == 9)
            {
                return "nine";
            }
            else
            {
                return "ten";
            }
        }

        public string GetTeens(int num)
        {
            if (num == 11)
            {
                return "eleven";
            }
            else if (num == 12)
            {
                return "tweleve";
            }
            else if (num == 13)
            {
                return "thirteen";
            }
            else if (num == 14)
            {
                return "forteen";
            }
            else if (num == 15)
            {
                return "fifteen";
            }
            else if (num == 16)
            {
                return "sixteen";
            }
            else if (num == 17)
            {
                return "seventeen";
            }
            else if (num == 18)
            {
                return "eighteen";
            }
            else
            {
                return "nineteen";
            }
          
        }

        public string GetTens(int num)
        {
            //check whats in the 10s slot and ones slot, delegate when appropriate to the ones method 
            string s = num.ToString();

            char ones = s[1];
            char tens = s[0];

            if(ones == '0')
            {
                if(tens == '2')
                {
                    return "twenty";
                }
            }
            else
            {
                string onesPlace = GetOnes(int.Parse(ones.ToString()));
                if (tens == '2')
                {
                    return "twenty"+ " " + onesPlace;
                }
            }

            return "";

        }
    }
}
