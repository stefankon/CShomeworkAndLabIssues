using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.DeserializeString
{
    class DeserializeString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, List<int>> dataText = new Dictionary<char, List<int>>();

            while (input != "end")
            {
                string[] tokens = input.Split(':');
                char @char = char.Parse(tokens[0]);
                List<int> index = tokens[1].Split('/').Select(int.Parse).ToList();

                dataText[@char] = index;

                input = Console.ReadLine();

            }

            var textToPrint = new StringBuilder();

            foreach (var kvp in dataText)
            {
                char @char = kvp.Key;
                int count = kvp.Value.Count;
                textToPrint.Append(@char, count);
            }

            foreach (var kvp in dataText)
            {
                char @char = kvp.Key;
                List<int> insertIndex = kvp.Value;
                foreach (var ind in insertIndex)
                {
                    textToPrint.Remove(ind, 1);
                    textToPrint.Insert(ind, @char);
                }
            }
            Console.WriteLine(textToPrint);
        }
    }
}
