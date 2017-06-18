using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.RemoveNegativesReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse).ToList();

            List<int> numsToRemove = new List<int>();

            int counter = 0;

            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                if (input[cnt] > 0)
                {
                    numsToRemove.Add(input[cnt]);
                    counter++;
                }
                
            }

            if (counter > 0)
            {
                numsToRemove.Reverse();
                Console.WriteLine(string.Join(" ", numsToRemove));
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
