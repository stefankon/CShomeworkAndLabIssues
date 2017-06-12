using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            char opertor = char.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int result = 0;

            switch (opertor)
            {
                case '+':
                    result = firstDigit + secondDigit;
                    break;
                case '-':
                    result = firstDigit - secondDigit;
                    break;
                case '*':
                    result = firstDigit * secondDigit;
                    break;
                case '/':
                    result = firstDigit / secondDigit;
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", firstDigit, opertor, secondDigit, result);
        }
    }
}
