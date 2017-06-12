using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13.DigitsWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int currentNumber = 0;

            switch (input)
            {
                case "zero":
                    currentNumber = 0;
                    break;
                case "one":
                    currentNumber = 1;
                    break;
                case "two":
                    currentNumber = 2;
                    break;
                case "three":
                    currentNumber = 3;
                    break;
                case "four":
                    currentNumber = 4;
                    break;
                case "five":
                    currentNumber = 5;
                    break;
                case "six":
                    currentNumber = 6;
                    break;
                case "seven":
                    currentNumber = 7;
                    break;
                case "eight":
                    currentNumber = 8;
                    break;
                case "nine":
                    currentNumber = 9;
                    break;
                default:
                    break;
            }
            Console.WriteLine(currentNumber);
        }
    }
}
