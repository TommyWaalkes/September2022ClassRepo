using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependcyInjection
{
    internal class ShapeCalculator
    {
        public IGetArea GetAreaMethod { get; set; }

        //Dependency injection is usually done through the constructor
        //I am allowed to pass in any child IGetArea, which makes our calculator more flexible 
        //I can customize my calculator to handle whatever shape I want. 
        public ShapeCalculator(IGetArea getAreaMethod)
        {
            GetAreaMethod = getAreaMethod;
        }

        public double GetArea()
        {
            //This delegates a call to the injected get area method
            return GetAreaMethod.GetArea();
        }
    }
}
