using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10.TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= counter; j++)
                {
                    Console.Write($"{counter} ");
                }
                counter++;
                Console.WriteLine();
            }


        }
    }
}
