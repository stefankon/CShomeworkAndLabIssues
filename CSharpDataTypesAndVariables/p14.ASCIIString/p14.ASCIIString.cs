using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14.ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            int countReader = int.Parse(Console.ReadLine());
            string textToPrint = String.Empty;

            for (int cnt = 0; cnt < countReader; cnt++)
            {
                int currentDigit = int.Parse(Console.ReadLine());
                char currentChar = Convert.ToChar(currentDigit);
                textToPrint += currentChar;
            }

            Console.WriteLine(textToPrint);
        }
    }
}
