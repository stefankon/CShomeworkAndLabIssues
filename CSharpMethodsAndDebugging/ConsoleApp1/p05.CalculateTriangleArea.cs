using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double wight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            PrintTriangleArea(wight, height);

        }

        static void PrintTriangleArea(double wight, double height)
        {
            double triangleArea = wight * height / 2;
            Console.WriteLine(triangleArea);
        }
    }
}
