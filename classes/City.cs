using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class City
    {
        public string cityName = "";
        public string cityCode = "";
        public string country = "";
        public uint totalPopulation = 0;
        public uint womenPopulation = 0;
        public uint menPopulation = 0;

        public City(string cityName, string cityCode, string country, uint totalPopulation, uint womenPopulation, uint menPopulation)
        {
            this.cityName = cityName;
            this.cityCode = cityCode;
            this.country = country;
            this.totalPopulation = totalPopulation;
            this.womenPopulation = womenPopulation;
            this.menPopulation = menPopulation;
        }

        public City(string cityName)
        {
            this.cityName = cityName;
        }
    }
}
