using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p10.CountOfNegativeElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());

            int[] arr = new int[numLines];

            int counter = 0;
            for (int cnt = 0; cnt < numLines; cnt++)
            {
                arr[cnt] = int.Parse(Console.ReadLine());
                if (arr[cnt] < 0)
                {
                    counter++;
                }

            }
            Console.WriteLine(counter);
        }
    }
}
