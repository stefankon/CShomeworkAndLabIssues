using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.FromTerabytesToBits
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tb = decimal.Parse(Console.ReadLine());
            decimal tbToBit = tb * 1024 * 1024 * 1024 * 1024 * 8;
            Console.WriteLine("{0:f0}", tbToBit);
        }
    }
}
