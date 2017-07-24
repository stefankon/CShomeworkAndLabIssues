using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п03.Camping
{
    class Camping
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dataCamp = 
                                                    new Dictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                string[] tokens = input.Split(' ').ToArray();

                string name = tokens[0];
                string model = tokens[1];
                int days = int.Parse(tokens[2]);

                if (!dataCamp.ContainsKey(name))
                {
                    dataCamp.Add(name, new Dictionary<string, int>());
                }
                if (!dataCamp[name].ContainsKey(model))
                {
                    dataCamp[name].Add(model, 0);
                }
                dataCamp[name][model] += days;
                input = Console.ReadLine();
            }
            var sortedData = dataCamp
                            .OrderByDescending(x => x.Value.Count)
                            .ThenBy(x => x.Key.Length);

            
            foreach (var kvp in sortedData)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                var total = kvp.Value.Values.Select(x => x).Sum();
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($"***{kvp2.Key}");
                }
                Console.WriteLine($"Total stay: {total} nights");
            }
        }
    }
}
