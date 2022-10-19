using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCarDealership
{
    internal class CarController
    {
        public List<Car> CarsInventory { get; set; } = new List<Car>();

        public CarController()
        {
            //Later on this data will come from external sources, but right now we're gonna fill it in 
            //in the constructor
            CarsInventory.Add(new Car() { Make = "Ford", Model = "Focus", Price = 3000, Year = 2015 });
            CarsInventory.Add(new Car() { Make = "Toyota", Model = "Camry", Price = 2500, Year = 2010 });
            CarsInventory.Add(new Car() { Make = "Chevy", Model = "Malibu", Price = 6000, Year = 2021 });
        }

        //Action's job is to pull everything together needed for a particular view 
        public void CarList()
        {
            //We need to make a view to handle displaying our listing of cars 
            //Then we want to allow the use to pick a car to learn its full details and try to purchase it
            CarListView cl = new CarListView(CarsInventory);
            int index = cl.Display();

            Car toBuy = CarsInventory[index];
            BuyCar(toBuy);
        }

        public void BuyCar(Car c)
        {
            BuyCarView bcv = new BuyCarView(c);
            bcv.Display();
        }
    }
}
