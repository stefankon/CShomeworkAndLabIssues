using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.OddNumbersOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputValues = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            for (int cnt = 1; cnt < inputValues.Length; cnt += 2)
            {
                if (inputValues[cnt] % 2 != 0)
                {
                    Console.WriteLine("Index {0} -> {1}",cnt, inputValues[cnt]);
                }
            }
        }
    }
}
