using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.SmallestElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] inputArr = new int[input.Length];
            for (int cnt = 0; cnt < inputArr.Length; cnt++)
            {
                inputArr[cnt] = int.Parse(input[cnt]);
            }

            int minValue = inputArr[0];

            for (int cnt = 1; cnt < input.Length; cnt++)
            {

                if (inputArr[cnt] < minValue)
                {
                    minValue = inputArr[cnt];
                }
            }


            Console.WriteLine(minValue);

        }
    }
}
