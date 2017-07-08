using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.CitiesContinentCountry
{
    class CitiesContinentCountry
    {
        static void Main(string[] args)
        {
            int lineCounter = int.Parse(Console.ReadLine());
            var continentsData = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < lineCounter; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];
                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new Dictionary<string, List<string>>();
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new List<string>();
                }

                continentsData[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> continentCountry in continentsData)
            {
                string continentName = continentCountry.Key;
                Dictionary<string, List<string>> countries = continentCountry.Value;
                Console.WriteLine($"{continentName}:");

                foreach (KeyValuePair<string, List<string>> cities in countries)
                {
                    string countryName = cities.Key;
                    List<string> cityName = cities.Value;
                    Console.WriteLine($"    {countryName} -> {string.Join(", ", cityName)}");
                }
            }
        }
    }
}
