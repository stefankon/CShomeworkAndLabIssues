using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var odd = 1;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + odd;
                Console.WriteLine(odd);
                odd += 2;
                
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
