using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p16.ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            int counter = arr.Length - 1;
            for (int cnt = 0; cnt < arr.Length; cnt++)
            {

                if (arr[cnt] != arr[counter])
                {
                    Console.WriteLine("No");
                    return;
                }
                counter--;

            }

            Console.WriteLine("Yes");

        }

    }
}


