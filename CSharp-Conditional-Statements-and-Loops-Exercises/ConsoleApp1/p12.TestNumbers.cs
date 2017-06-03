using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var maximumSum = int.Parse(Console.ReadLine());

            var totalSum = 0;
            var counter = 0;


            for (int firstDigit = firstNumber; firstDigit >= 1; firstDigit--)
            {

                for (int secondDigit = 1; secondDigit <= secondNumber; secondDigit++)
                {
                    if (totalSum > maximumSum)
                    {
                        break;
                    }

                    //Console.Write($"{firstDigit} {secondDigit}; ");
                    totalSum = totalSum + (3 * (firstDigit * secondDigit));
                    counter++;

                }

            }
            if (totalSum >= maximumSum)
            {
                Console.WriteLine();
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {maximumSum}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
            
        }
    }
}
