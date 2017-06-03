using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var lastFirstNumber = 0;
            var lastSecondNumber = 0;
            var counter = 0;
  


            for (int firstDigit = firstNumber; firstDigit <= secondNumber; firstDigit++)
            {

                for (int secondDigit = firstNumber; secondDigit <= secondNumber; secondDigit++)
                {
                   

                    if ((firstDigit + secondDigit) == magicalNumber)
                    {
                        lastFirstNumber = firstDigit;
                        lastSecondNumber = secondDigit;


                    }


                    //Console.Write($"{firstDigit} {secondDigit}; ");
                    //Console.Write($"{lastFirstNumber} {lastSecondNumber}; ");

                    counter++;
                }

               
            }

            
            if ((lastFirstNumber + lastSecondNumber) == 0)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }
            else
            {
                Console.WriteLine("Number found! {0} + {1} = {2}", lastFirstNumber, lastSecondNumber, 
                    lastFirstNumber + lastSecondNumber);
                //Console.WriteLine($"Sum: {totalSum}");
            }

        }
    }
}
