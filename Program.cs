using Program;

namespace importMiasta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\student\Desktop\today\importMiasta\importMiasta\csv\population.csv";

            CsvReader csvReader = new CsvReader(filePath);
            City[]? cities = csvReader.ReadFirstNcities(5);

            /*foreach(var city in cities)
            {
                Console.WriteLine("Miasto");
            }*/

            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            City c = csvReader.readCityFromCsvLine(line);
            Console.WriteLine(c.cityName);

        }
    }
}