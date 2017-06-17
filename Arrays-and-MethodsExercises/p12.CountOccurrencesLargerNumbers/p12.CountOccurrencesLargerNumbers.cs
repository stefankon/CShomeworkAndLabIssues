using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12.CountOccurrencesLargerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            double[] doubleArr = new double[arr.Length];
            double numToCompare = double.Parse(Console.ReadLine());

            int counter = 0;

            for (int cnt = 0; cnt < doubleArr.Length; cnt++)
            {
                doubleArr[cnt] = double.Parse(arr[cnt]);
                if (doubleArr[cnt] > numToCompare)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
