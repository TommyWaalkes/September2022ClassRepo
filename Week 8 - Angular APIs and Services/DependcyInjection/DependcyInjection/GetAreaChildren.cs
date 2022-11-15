using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependcyInjection
{
    class GetSquare : IGetArea
    {
        public double GetArea()
        {
            Console.WriteLine("Please input a length");
            double len = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input a Width");
            double wid = double.Parse(Console.ReadLine());

            return wid * len;
        }
    }

    class GetCircle : IGetArea
    {
        public double GetArea()
        {
            Console.WriteLine("Please input a radius");
            double rad = double.Parse(Console.ReadLine());

            double area = Math.PI * rad * rad;

            return area;
        }
    }

    class GetTriangle: IGetArea
    {
        public double GetArea()
        {
            Console.WriteLine("Please input a length");
            double len = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input a Width");
            double wid = double.Parse(Console.ReadLine());

            return (wid * len) / 2;
        }
    }
}
