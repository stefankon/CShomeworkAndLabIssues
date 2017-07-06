using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputLine = Console.ReadLine().Split(' ')
                              .Select(int.Parse).ToArray();
            int numberFinding = int.Parse(Console.ReadLine());

            bool isFound = false;
            int itearationsL = 0;
            int itearationsB = 0;

            LinearySearch(ref inputLine, ref numberFinding, ref isFound, ref itearationsL);

            BinarySearch(ref inputLine, ref numberFinding, ref isFound, ref itearationsB);

            if (isFound)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Linear search made {itearationsL} iterations");
                Console.WriteLine($"Binary search made {itearationsB} iterations");
            }
            else //Numbert is not isFound!
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {itearationsL} iterations");
                Console.WriteLine($"Binary search made {itearationsB} iterations");
            }
        }
        private static void BinarySearch(ref int[] inputLine, ref int numberFinding,
                                           ref bool isFound, ref int itearationsB)
        {

            NewSortList(ref inputLine);
            int searchkey = numberFinding;
            itearationsB = 0;

            isFound = false;

            int mid = 0, first = 0, last = inputLine.Length - 1;


            //for a sorted array with ascending values
            while (!isFound && first <= last)
            {
                mid = (first + last) / 2;
               
                if (numberFinding == inputLine[mid])
                    isFound = true;
                else
                {
                    if (numberFinding > inputLine[mid])
                    {
                        first = mid + 1;
                    }

                    if (numberFinding < inputLine[mid])
                    {
                        last = mid - 1;
                    }

                }

                itearationsB++;
            }

        }

        private static void NewSortList(ref int[] inputLine)
        {
            List<int> newSorted = new List<int>(inputLine);
            newSorted.Sort();
            for (int i = 0; i < newSorted.Count; i++)
            {
                inputLine[i] = newSorted[i];
            }
        }

        private static void LinearySearch(ref int[] inputLine, ref int numberFinding,
                                            ref bool isFound, ref int itearationsL)
        {
            foreach (var item in inputLine)
            {
                itearationsL++;
                if (item == numberFinding)
                {
                    isFound = true;
                    return;
                }
                else
                {
                    isFound = false;
                }
            }
        }
    }
}
