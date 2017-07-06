using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            char[] inputLine = Console.ReadLine().ToCharArray();

            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char item in inputLine)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }

            foreach (KeyValuePair<char, int> item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
