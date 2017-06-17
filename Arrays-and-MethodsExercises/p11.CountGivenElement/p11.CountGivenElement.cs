using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11.CountGivenElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int[] intArr = new int[arr.Length];
            int numToCompare = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int cnt = 0; cnt < intArr.Length; cnt++)
            {
                intArr[cnt] = int.Parse(arr[cnt]);
                if (intArr[cnt] == numToCompare)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
