using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16.TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            string textToPrint = String.Empty;
            string currentString = String.Empty;

            for (int cnt = 0; cnt < counter - 1; cnt++)
            {
                currentString = Console.ReadLine();
                textToPrint += currentString + delimiter;
            }
            currentString = Console.ReadLine();
            textToPrint += currentString;

            Console.WriteLine(textToPrint);

        }
    }
}
