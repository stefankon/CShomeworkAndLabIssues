using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputFirstLine = Console.ReadLine().ToArray();
            int[] inputSecondLine = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            string textToPrint = string.Empty;

            for (int cnt = 0; cnt < inputFirstLine.Length; cnt++)
            {
                int currentNum = inputFirstLine[cnt];
                char currentChar = '0';

                if (inputSecondLine[cnt] % 2 != 0)
                {
                    currentChar = (char)(currentNum + inputSecondLine[cnt]);
                }
                else
                {
                    currentChar = (char)(currentNum - inputSecondLine[cnt]);
                }

                textToPrint += currentChar;
            }
            Console.WriteLine(textToPrint);
        }
    }
}
