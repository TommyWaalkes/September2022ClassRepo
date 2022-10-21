using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCountries
{
    public enum Continent
    {
        Asia,
        Europe,
        Australia, 
        NorthAmerica,
        SouthAmerica,
        Antartica, 
        Africa
    }

    //This is a model its only job is to hold data 
    internal class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }
    }
}
