using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {

            int numLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numLines; i++)
            {
                long inputLine = NumToWord(long.Parse(Console.ReadLine()));
            }

        }

        static long NumToWord(long inputNum)
        {
            long input = Math.Abs(inputNum);

            long digit1 = (input / 100);
            long digit2 = (((input / 10) % 10));
            long digit3 = ((input % 10) % 10);

            string[] oneToTen = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tenTh = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string hundred = "-hundred";
            string and = " and ";
            string digitToText = string.Empty;



            if ((-1000 < inputNum) && (inputNum < 1000))
            {
                if (digit1 != 0)
                {
                    digitToText += oneToTen[digit1 - 1] + hundred;
                }

                if ((digit2 + digit3) != 0)
                {
                    digitToText += and;
                }
                if (digit2 >= 2)
                {
                    digitToText += tenTh[digit2 - 1] + " ";
                }

                else if (digit2 == 1)
                {
                    if (digit3 != 0)
                    {
                        digitToText += teen[digit3 - 1];
                    }
                    else if ((digit2 == 1) && (digit3 == 0))
                    {
                        digitToText += tenTh[0];
                    }
                }
                if ((digit2 != 1) && (digit3 != 0))
                {
                    digitToText += oneToTen[digit3 - 1];
                }

            }


            if ((99 < inputNum) && (inputNum <= 999))
            {
                Console.WriteLine(digitToText);
            }
            else if ((-99 > inputNum) && (inputNum >= -999))
            {
                Console.WriteLine($"minus {digitToText}");
            }
            else if (inputNum >= 1000)
            {
                Console.WriteLine("too large");
            }
            else if (inputNum <= -1000)
            {
                Console.WriteLine("too small");
            }
            else
            {
                Console.WriteLine();
            }

            return 0;
        }
    }
}


