using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 0;
            var counter = 0;

            while (true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    counter++;
                }
                catch (Exception ex)
                {
                    break;

                }
            }

            Console.WriteLine($"{counter}");
        }
    }
}
