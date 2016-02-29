using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryStatistics
{
    public class Country
    {
        public string CountryName { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }

        public Country(string countryName, string capital, int population) 
        {
            this.CountryName = countryName;
            this.Capital = capital;
            this.Population = population;
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.CountryName, this.Capital, this.Population);
        }
    }
}