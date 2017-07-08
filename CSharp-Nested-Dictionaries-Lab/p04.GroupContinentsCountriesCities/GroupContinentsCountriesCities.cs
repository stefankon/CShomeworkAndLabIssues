using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.GroupContinentsCountriesCities
{
    class GroupContinentsCountriesCities
    {
        static void Main(string[] args)
        {
            int lineCounter = int.Parse(Console.ReadLine());
            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < lineCounter; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                var continent = tokens[0];
                var country = tokens[1];
                var city = tokens[2];
                if (!continentsData.ContainsKey(continent))
                {
                    continentsData[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!continentsData[continent].ContainsKey(country))
                {
                    continentsData[continent][country] = new SortedSet<string>();
                }

                continentsData[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> continentCountry in continentsData)
            {
                string continentName = continentCountry.Key;
                SortedDictionary<string, SortedSet<string>> countries = continentCountry.Value;
                Console.WriteLine($"{continentName}:");

                foreach (KeyValuePair<string, SortedSet<string>> cities in countries)
                {
                    string countryName = cities.Key;
                    SortedSet<string> cityName = cities.Value;
                    Console.WriteLine($"    {countryName} -> {string.Join(", ", cityName)}");
                }
            }
        }
    }
}
