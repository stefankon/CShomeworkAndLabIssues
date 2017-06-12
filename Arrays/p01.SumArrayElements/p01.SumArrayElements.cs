using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.SumArrayElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] inputArr = new int[input];
            int sum = 0;

            for (int cnt = 0; cnt < input; cnt++)
            {
                inputArr[cnt] = int.Parse(Console.ReadLine());
                sum += inputArr[cnt];
            }

            Console.WriteLine(sum);
        }
    }
}
