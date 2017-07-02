using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();

            Dictionary<string, int> inputElements = new Dictionary<string, int>();

            foreach (string word in input)
            {
                if (inputElements.ContainsKey(word))
                {
                    inputElements[word]++;
                }
                else
                {
                    inputElements[word] = 1;
                }
            }
            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> word in inputElements)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }

            Console.WriteLine(String.Join(", ", result));
        }
    }
}

