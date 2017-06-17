using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine().ToLower();
            char separator = ' ';
            string[] compareWords = inputString.Split(separator);

            string stringToPrint = String.Empty;

            for (int cnt = 0; cnt < compareWords.Length - 2; cnt++)
            {
               
                if ((compareWords[cnt] == compareWords[cnt + 1]) && (compareWords[cnt] == compareWords[cnt + 2]))
                {
                    stringToPrint = compareWords[cnt] + " " + compareWords[cnt+1] + " " + compareWords[cnt+2];
                  
                }

            }

            Console.WriteLine(stringToPrint);

        }
    }
}
