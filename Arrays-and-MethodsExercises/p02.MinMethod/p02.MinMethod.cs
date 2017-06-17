using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int d = GetMin(a, b);
            Console.WriteLine("{0}", (c < d) ? c : d);
           
        }

        static int GetMin(int a, int b)
        {
            int result = (a < b) ? a : b;
            return result;
        }
    }
}
