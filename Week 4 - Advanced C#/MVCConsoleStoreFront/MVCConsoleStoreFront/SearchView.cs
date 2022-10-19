using System;
using System.Collections.Generic;
using System.Text;

namespace MVCConsoleStoreFront
{
    class SearchView
    {
        //1) Display a prompt to tell user please search a category 
        //2) Grab user input 
        //3) Pass that input along so it can be used to query our list
        public string Display()
        {
            Console.WriteLine("Please enter a category you wish to search for:");
            string input = Console.ReadLine();

            //Actual searching gets done over in the controller 
            //The controller will have full access to the DB 
            //The view just handles the input/output
            return input;

        }

    }
}
