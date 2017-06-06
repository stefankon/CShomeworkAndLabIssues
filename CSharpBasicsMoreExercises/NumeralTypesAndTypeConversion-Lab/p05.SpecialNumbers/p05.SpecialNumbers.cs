using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentNum = 0;

            for (int printLineNum = 1; printLineNum <= inputNumber; printLineNum++)
            {
                for (int i = 0; i < printLineNum; i++)
                {
                    currentNum = printLineNum;
                    sum = 0;
                    while (currentNum != 0)
                    {
                        sum += currentNum % 10;
                        currentNum /= 10;

                    }

                }

                bool specialNumbers = (sum == 5) || (sum == 7) || (sum == 11);


                if (specialNumbers)
                {
                    Console.WriteLine($"{printLineNum} -> True");
                }
                else
                {
                    Console.WriteLine($"{printLineNum} -> False");
                }


            }
        }
    }
}
