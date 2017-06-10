using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.IncrementVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int timeOverflowed = 0;

            if (input / 256 > 0)
            {
                timeOverflowed = input / 256;
            }
            else if (input / 256 == 0)
            {
                timeOverflowed = 1;
            }

            if (input >= 256)
            {
                Console.WriteLine("{0}", input - (timeOverflowed * 256));
                Console.WriteLine("Overflowed {0} times", timeOverflowed);
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
