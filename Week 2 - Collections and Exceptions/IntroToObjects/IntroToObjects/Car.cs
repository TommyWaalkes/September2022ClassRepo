using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name spaces are merely grouping of classes, if 2 classes share a namespace they can freely talk to each other 
//Otherwise you have import the other files namespace. 
namespace IntroToObjects
{
    public class Car
    {
        //1) Properties - Yes we want to track price, make model color, year
        //2) Constructor - Yes as well, we want to use the constructor to fill in our properties 
        //3) Methods - No - we just represent to sell it, we don't care driving/accelerating 

        //The get and set allow us to alter the properties as the class is running 
        //There a lot with these so for right now know the get and set need to be there 
        //Reason being is a) they're useful and b) .NET LOVES properties

        //In C#, Properties, which available to the whole class, are written in title case 
        //Local variables that in a method are still done in camelCase
        public string Make;
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        //Like variables you can set a property to have initial value
        public double MilesTraveled { get; set; } = 0;

        //Constructors are methods without a return type or static, they build and return an instance of the matching class
        //In order to tell C# I am making a Car constructor the signature MUST match the name of the class. Spelling matters, Casing matters

        //When I put paramteters into my constructor I am telling others, this object REQUIRES these inputs 
        //By having the parameter match the properties I am telling other, these parameters are intend to fill in properties
        public Car(string Make, string Model, string Color, int Year)
        {
            //Why do we want to do the this.Make? fill out my property 
            //Other languages call their this keyword as self. 
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Color = Color; 
        }

        //Noticed the method in our class lacks static 
        public void Drive()
        {
            MilesTraveled++;
        }
    }
}
