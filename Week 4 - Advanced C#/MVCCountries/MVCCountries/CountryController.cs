using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    //The job of the controller is 1) dictate the flow the app, which view get shown and when, 2) pull in any data needed for a particular view
    internal class CountryController
    {
        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            //What will happen later on in the course is that we'll have code that can grab items from SQL and dump them into a list
            Country c
               = new Country() { Name = "USA", Continent = Continent.NorthAmerica, Colors = new List<string>() { "Red", "White", "Blue" } };

            CountryDb = new List<Country>();
            CountryDb.Add(c);
            CountryDb.Add(new Country() { Name = "Spain", Continent = Continent.Europe, Colors = new List<string>() { "Yellow", "Red" } });
            CountryDb.Add(new Country() { Name = "Japan", Continent = Continent.Asia, Colors = new List<string>() { "White", "Red" } });

        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            Console.WriteLine("Welcome to our app, please select a country from the following list:");
            CountryListView clv = new CountryListView(CountryDb);
            clv.Display();

            //In a web MVC app, user input is handled as a joint operation between views and controllers
            //The view gets the input and controller processes, but this operation doesn't translate to console apps 
            //So we picked a spot to put it 
            string input = Console.ReadLine();

            int pick = int.Parse(input);

            Country selected = CountryDb[pick];

            //In a web app this would be called a redirect 
            CountryAction(selected);
        }
    }
}
