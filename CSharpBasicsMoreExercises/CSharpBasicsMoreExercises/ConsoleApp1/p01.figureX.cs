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
            var num = int.Parse(Console.ReadLine());

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if ((col == row) || (col == num - row - 1))
                    {
                        Console.Write('x');
                    }
                    else
                    {
                        Console.Write(' ');
                    }

                }
                Console.Write('\n');
            }
        }
    }
}
