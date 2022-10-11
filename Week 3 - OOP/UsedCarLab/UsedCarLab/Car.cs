using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsedCarLab
{
    public class Car
    {
        //make model year price 
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        
        //This sets all my variables to default
        public Car()
        {

        }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        //To String comes from the objects class and all classes have it 
        //However, by default without override it, ToString returns the type of object 
        //and not its contents, but if override it then we customize it 

        //So anytime an object would be turned into a string, it's toString method gets called 
        //Which can be handy specifically for printing out the object 
        public override string ToString()
        {
            string output = $"Make: {Make}, Model: {Model}, Year:{Year}, Price:{Price} ";
            return output;
        }
    }
}
