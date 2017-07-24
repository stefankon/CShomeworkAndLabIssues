using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.ArrayData
{
    class ArrayData
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            long[] arrayData = input
                            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(long.Parse)
                            .ToArray();

            double averrage = arrayData.Average();
            long[] remaining = arrayData.OrderBy(x => x).Where(x => x >= averrage).ToArray();

            int min = 0;
            int max = 0;
            int empty = 0;

            if (remaining.Length == 0)
            {
                if (command == "Min")
                {
                    Console.WriteLine(min);
                }
                else if (command == "Max")
                {
                    Console.WriteLine(max);
                }
                else
                {
                    Console.WriteLine(input);
                }
            }
            else
            {
                if (command == "Min")
                {
                    Console.WriteLine(remaining.Min());
                }
                else if (command == "Max")
                {
                    Console.WriteLine(remaining.Max());
                }
                else
                {
                    Console.WriteLine(string.Join(" ", remaining));
                }
            }
        }
    }
}
