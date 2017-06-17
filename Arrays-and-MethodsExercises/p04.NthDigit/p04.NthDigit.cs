using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            string lenghtInt = Convert.ToString(number);
            int nthDigit = (lenghtInt.Length - index);

            Console.WriteLine(lenghtInt[nthDigit]);
        }
    }
}
