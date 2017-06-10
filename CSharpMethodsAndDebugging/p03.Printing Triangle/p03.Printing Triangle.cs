using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            UperPintNumbers(num);
            PrintLine(1, num);
            DownPrintNumbers(num);


        }

        static void PrintLine(int start, int end)
        {

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static void UperPintNumbers(int num)
        {
            for (int i = 0; i < num; i++)
            {
                PrintLine(1, i);
            }
        }

        static void DownPrintNumbers(int num)
        {
            for (int i = num - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }

        }
            
    }
}
