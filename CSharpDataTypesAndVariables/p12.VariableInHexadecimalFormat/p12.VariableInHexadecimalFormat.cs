using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int decValue = Convert.ToInt32(number, 16);
            Console.WriteLine(decValue);
        }
    }
}
