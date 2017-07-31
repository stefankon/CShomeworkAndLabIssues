using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.Warmtest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            double widht = double.Parse(Console.ReadLine());

            long convertedLenght = lenght * 100;
            double calculation = convertedLenght % widht;
            double product = convertedLenght * widht;
            double percentage = (convertedLenght / widht) * 100;
            double empty = 0.00000001;

            if (calculation != 0 && widht != 0)
            {
                Console.WriteLine("{0:F2}%", percentage);
            }
            else if (lenght != 0 || widht != 0)
            {
                Console.WriteLine("{0:F2}", product);
            }
            else if (widht == 0)
            {
               Console.WriteLine("{0:F2}", empty);
            }
        }
    }
}
