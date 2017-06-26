using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListInput = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            List<int> secondListInput = Console.ReadLine()
                                       .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            RemoveEqualElements(firstListInput, secondListInput);

            if (SumFirstLists(firstListInput) == SumSecondLists(secondListInput))
            {
                Console.WriteLine($"Yes. Sum: {SumFirstLists(firstListInput)}");
            }
            // The sums of two lists are not equals 
            else
            {
                int defference = Math.Abs(SumFirstLists(firstListInput) - SumSecondLists(secondListInput));
                Console.WriteLine($"No. Diff: {defference}");
            }
        }

        static void RemoveEqualElements(List<int> firstListInput, List<int> secondListInput)
        {
            for (int i = 0; i < firstListInput.Count; i++)
            {
                if (secondListInput.Contains(firstListInput[i]))
                {
                    secondListInput.Remove(firstListInput[i]);
                    secondListInput.Remove(firstListInput[i]);
                    i--;
                }
            }
        }

        static int SumFirstLists(List<int> firstListInput)
        {
            int sumFirstList = 0;
            for (int cnt = 0; cnt < firstListInput.Count; cnt++)
            {
                sumFirstList += firstListInput[cnt];
            }
            return sumFirstList;
        }

        static int SumSecondLists(List<int> SumSecondLists)
        {
            int sumSecondLists = 0;
            for (int cnt = 0; cnt < SumSecondLists.Count; cnt++)
            {
                sumSecondLists += SumSecondLists[cnt];
            }
            return sumSecondLists;
        }
    }
}

