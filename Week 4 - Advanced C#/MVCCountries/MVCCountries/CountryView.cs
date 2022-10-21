using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public void Display()
        {
            Console.WriteLine("Country: "+DisplayCountry.Name);
            Console.WriteLine("Continent: "+ DisplayCountry.Continent);

            Console.WriteLine("Colors: ");
            foreach(string color in DisplayCountry.Colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
