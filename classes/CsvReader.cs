using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class CsvReader
    {
        private string? filePath;

        public CsvReader(string _filePath)
        {
            filePath = _filePath;
        }

        public City[]? ReadFirstNcities(uint nCities)
        {
            //return null;
            City[] cities = new City[nCities];
            return cities;
        }

        public City readCityFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');

            string cityName = parts[0];
            
            return new City(cityName);
        }
    }
}
