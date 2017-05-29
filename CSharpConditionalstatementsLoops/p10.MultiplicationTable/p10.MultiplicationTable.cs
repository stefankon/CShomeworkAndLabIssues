using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            do
            {

                Console.WriteLine("{0} X {1} = {2}", n, multiplier, n * multiplier);
                multiplier++;


            } while (multiplier <= 10);


        }
    }
}
