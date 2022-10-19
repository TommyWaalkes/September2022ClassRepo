using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCarDealership
{
    internal class BuyCarView
    {
        public Car CarToBuy { get; set; }

        public BuyCarView(Car CarToBuy)
        {
            this.CarToBuy = CarToBuy;
        }

        //In our display method lets print the full car details and ask if the user is sure they wish to buy that car 
        //Once they say yes, we'll double the price on them. 
        public void Display()
        {
            Console.WriteLine("Full Details on the Car");
            Console.WriteLine(CarToBuy.Make);
            Console.WriteLine(CarToBuy.Model);
            Console.WriteLine(CarToBuy.Year);
            Console.WriteLine(CarToBuy.Price);

            Console.WriteLine("You know I like you, you're like smart, I will give you a discount as crazy discount Dan");
            Console.WriteLine("Discounted Price: " + CarToBuy.Price/2);

            Console.WriteLine("Would you like to buy this car? Y/N");
            string input = Console.ReadLine().ToLower().Trim();

            if(input == "y")
            {
                Console.WriteLine("Okay with the hidden fees your purchase comes out to be " + CarToBuy.Price *2);
            }
            else if(input == "n")
            {
                Console.WriteLine("Okay! I don't want to be sued for forcing someone to buy a car, I will just call you daily until you buy from me.");
            }
        }
    }
}
