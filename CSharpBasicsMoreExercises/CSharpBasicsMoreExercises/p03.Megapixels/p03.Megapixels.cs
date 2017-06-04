using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            decimal megapixels = (decimal)(width * height) / 1000000;
            decimal result = Math.Round(megapixels, 1);

            Console.WriteLine($"{width}x{height} => {result}MP");
        }
    }
}
