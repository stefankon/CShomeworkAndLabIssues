using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.MultiplyArrayDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputValues = Console.ReadLine()
                                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                                .Select(double.Parse)
                                .ToArray();

            double multiplayer = double.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < inputValues.Length; cnt++)
            {
                inputValues[cnt] *= multiplayer;
                Console.Write("{0} ", inputValues[cnt]);
            }

        }
    }
}
