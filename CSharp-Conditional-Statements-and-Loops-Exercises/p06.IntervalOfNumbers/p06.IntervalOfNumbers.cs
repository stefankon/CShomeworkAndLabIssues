using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondtNum = int.Parse(Console.ReadLine());
            var smallerNum = 0;
            var biggerNum = 0;

            if (firstNum > secondtNum)
            {
                smallerNum = secondtNum;
                biggerNum = firstNum;
            }
            else
            {
                smallerNum = firstNum;
                biggerNum = secondtNum;
            }

            for (int i = smallerNum; i <= biggerNum; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
