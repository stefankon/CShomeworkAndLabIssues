using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p09.LargestElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = int.Parse(Console.ReadLine());

            int[] arr = new int[numLines];

            int largestElement = int.MinValue;
            for (int cnt = 0; cnt < numLines; cnt++)
            {
                arr[cnt] = int.Parse(Console.ReadLine());
                if (arr[cnt] > largestElement)
                {
                    largestElement = arr[cnt];
                }
              
            }
            Console.WriteLine(largestElement);
        }
    }
}
