using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsoleStoreFront
{
    class WelcomeView
    {
        //The job of the view is to contain what the user will see 
        //Colors, styling, input/ouput are all handled down in the view
        //In the real world views are HTML/CSS and sometimes JS 

        public void Display()
        {
            Console.WriteLine("Welcome to our shop");
            Console.WriteLine("Please feel free to search and look for any of our products");
            Console.WriteLine("Press any key to continue to the search page");
            //I am using read key to force our app to pause on the welcome view
            Console.ReadKey();
            Console.WriteLine();
            Console.Clear();
        }
    }
}
