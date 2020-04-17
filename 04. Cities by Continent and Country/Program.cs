using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main()
        {
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();
            var numberInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberInput; i++)
            {
                var info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var continent = info[0];
                var countrie = info[1];
                var city = info[2];

                if (!continents.ContainsKey(continent))
                {
                    var cityes = new List<string> { city };
                    var nestedInfo = new Dictionary<string, List<string>>();
                    nestedInfo.Add(countrie, cityes);
                    continents.Add(continent, nestedInfo);
                }
                else if (!continents[continent].ContainsKey(countrie))
                {
                    var cityes = new List<string> { city };
                    continents[continent].Add(countrie, cityes);
                }
                else
                {
                    continents[continent][countrie].Add(city);
                }
            }
            foreach (var continentName in continents)
            {
                string name = continentName.Key;
                var countryes = continentName.Value;
                Console.WriteLine($"{name}:");
                foreach (var country in countryes)
                {
                    string cName = country.Key;
                    var cityList = country.Value;
                    Console.WriteLine($"  {cName} -> {string.Join(", ", cityList)}");
                }
            }
        }
    }
}
