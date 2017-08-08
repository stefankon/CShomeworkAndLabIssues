using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.SerializeString
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, List<int>> data
                                = new Dictionary<char, List<int>>();
            int index = 0;

            foreach (var @char in input)
            {
                if (!data.ContainsKey(@char))
                {
                    data[@char] = new List<int>();
                }
                data[@char].Add(index);
                index++;

            }

            foreach (var kvp in data)
            {
                char @char = kvp.Key;
                List<int> currIndex = kvp.Value;
                Console.Write($"{@char}:");
                Console.Write(string.Join("/", currIndex));
                Console.WriteLine();
            }
        }
    }
}
