using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14.EqualSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            int[] intArr = new int[arr.Length];

            for (int cnt = 0; cnt < intArr.Length; cnt++)
            {
                intArr[cnt] = int.Parse(arr[cnt]);
            }
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                if (intArr[i + 1] != intArr[i])
                {
                    Console.WriteLine("No");
                    return;
                }

            }
            Console.WriteLine("Yes");
        }
    }
}
