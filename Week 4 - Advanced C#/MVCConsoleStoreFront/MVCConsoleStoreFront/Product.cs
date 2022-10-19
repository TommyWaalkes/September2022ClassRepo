using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsoleStoreFront
{
    public class Product
    {
        //This will be our model 
        //Generally models act as our container for data 
        //So they often, if no external data being pulled in, 
        //Consist of just properties. 
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }

        public string Category { get; set; }

    }
}
