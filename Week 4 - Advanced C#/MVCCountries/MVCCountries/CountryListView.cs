using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    internal class CountryListView
    {
        public List<Country> CountryList { get; set; }

        public CountryListView(List<Country> countryList)
        {
            CountryList = countryList;
        }

        public void Display()
        {
            for(int i = 0; i < CountryList.Count; i++)
            {
                Country country = CountryList[i];
                Console.WriteLine($"{i} : {country.Name}");
            }
        }
    }
}
