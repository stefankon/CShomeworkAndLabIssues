using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            int baseToConvert = int.Parse(Console.ReadLine());

            IntBase(decimalNumber, baseToConvert);

        }

        static void IntBase(int number, int toBase)
        {
            string result = String.Empty;
            int remainder = 0;
            do
            {
                int curentDigit = number % toBase;
                string digitTostring = Convert.ToString(curentDigit);
                remainder = number / toBase;
                number = remainder;
                result = digitTostring + result;

            } while (remainder != 0);

            Console.WriteLine(result);
        }
    }
}
