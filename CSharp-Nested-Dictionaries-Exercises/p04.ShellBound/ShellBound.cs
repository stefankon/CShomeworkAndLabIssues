using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.ShellBound
{
    class ShellBound
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, HashSet<int>> shellBound = new Dictionary<string, HashSet<int>>();

            while (inputLine != "Aggregate")
            {
                string[] tokens = inputLine.Split(' ');

                string region = tokens[0];
                int shellSize = int.Parse(tokens[1]);

                if (!shellBound.ContainsKey(region))
                {
                    shellBound[region] = new HashSet<int>();
                }
                shellBound[region].Add(shellSize);


                inputLine = Console.ReadLine();
            }

            foreach (var kvp in shellBound)
            {
                string currentRegion = kvp.Key;
                HashSet<int> eachShell = new HashSet<int>(kvp.Value);
                int totalSum = kvp.Value.Sum();
                int average = (int)kvp.Value.Average();
                int bigOneShell = (totalSum - average);

                Console.WriteLine($"{currentRegion} -> {string.Join(", ", eachShell)} ({bigOneShell})");

            }
        }
    }
}
