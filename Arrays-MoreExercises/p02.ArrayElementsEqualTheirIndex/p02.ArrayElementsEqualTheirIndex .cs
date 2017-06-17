using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.ArrayElementsEqualTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputValues = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            for (int cnt = 0; cnt < inputValues.Length; cnt++)
            {
                if (inputValues[cnt] == cnt)
                {
                    Console.Write("{0} ", inputValues[cnt]);
                }
            }
            Console.WriteLine();
        }
    }
}
