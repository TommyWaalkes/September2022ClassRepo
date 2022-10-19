using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCarDealership
{
    internal class CarListView
    {
        public List<Car> Cars { get; set; };

        //I want to require that this view gets a car list 
        public CarListView(List<Car> Cars)
        {
            this.Cars = Cars;
        }

        public int Display()
        {
            Console.WriteLine("Welcome to our Car Dealership. Discount Dans Dirty Deals, to make you feel safe and not greasy");
            Console.WriteLine("Please select a car to purchase");

            for(int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine(i +" "+ Cars[i].Model);
            }

            string input = Console.ReadLine();
            int index = int.Parse(input);

            return index;
            //There 2 different ways MVC would proceed here
            //1) Grab the object directly - good if you're displaying right away 
            //2) Grab the index of the object and save to look up later, in web its easier to remember a single number vs a whole object 
        }
    }
}
