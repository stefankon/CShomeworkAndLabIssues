using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {
            var kilometes = double.Parse(Console.ReadLine());

            var convertor = kilometes * 1.60934;

            Console.WriteLine($"{convertor:F2}");
        }
    }
}
