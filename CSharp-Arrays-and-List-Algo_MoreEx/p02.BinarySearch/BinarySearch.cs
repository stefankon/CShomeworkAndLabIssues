using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.BinarySearch
{
    class PrograBinarySearchm
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
            else //Numbert is not found!
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {itearationsL} iterations");
                Console.WriteLine($"Binary search made {itearationsB} iterations");
            }


        }

        private static void BinarySearch(ref int[] inputLine, ref int numberFinding,
                                            bool isFound, ref int itearationsB)
        {
            while (true)
      if upperBound < lowerBound
         EXIT: x does not exists.


      set midPoint = lowerBound + (upperBound - lowerBound) / 2


      if A[midPoint] < x
         set lowerBound = midPoint + 1


      if A[midPoint] > x
         set upperBound = midPoint - 1

      if A[midPoint] = x
         EXIT: x found at location midPoint

   end while;
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
            };
        }
    }
}
