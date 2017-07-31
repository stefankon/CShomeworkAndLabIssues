using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string occurrency = Console.ReadLine().ToLower();

            int counter = 0;
            int index = inputText.IndexOf(occurrency);

            while (index != -1)
            {
                counter++;
                index = inputText.IndexOf(occurrency, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
