using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.AverageCharacterDelimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            List<char> stringToPrint = new List<char>();
            

            char[] temp = { };
            int totalSum = 0;
            int totalCounter = 0;

            for (int cnt1 = 0; cnt1 < input.Length; cnt1++)
            {
                int counter = input[cnt1].Length;
                for (int cnt2 = 0; cnt2 < counter; cnt2++)
                {
                    temp = input[cnt1].ToCharArray();
                    totalSum += temp[cnt2];
                    totalCounter++;
                }
            }
            int average = totalSum / totalCounter;
            string toUpper = ((char)average).ToString().ToUpper();
            char toRepalce = char.Parse(toUpper);
            
            Console.WriteLine(string.Join($"{toUpper}", input));
           
        }
    }
}
