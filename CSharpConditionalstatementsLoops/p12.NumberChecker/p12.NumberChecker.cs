using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double num = double.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input!");
                
            }
        }
    }
}
