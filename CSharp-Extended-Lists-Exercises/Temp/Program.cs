using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int commonMinLenght = CommonMinLenght(firstList, secondList);
            List<int> firstFliteredList = new List<int>();
            List<int> secondFliteredList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (FindNumberLenght(firstList[i]) <= commonMinLenght)
                {
                    firstFliteredList.Add(firstList[i]);
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                if (FindNumberLenght(secondList[i]) <= commonMinLenght)
                {
                    secondFliteredList.Add(secondList[i]);
                }
            }

            List<int> result = new List<int>();
            for (int i = 0; i < Math.Max(firstFliteredList.Count, secondFliteredList.Count); i++)
            {
                if (i < secondFliteredList.Count)
                {
                    result.Add(secondFliteredList[i]);
                }
                if (i < firstFliteredList.Count)
                {
                    result.Add(firstFliteredList[i]);
                }
            }
            //Console.WriteLine(String.Join(" ", firstFliteredList));
           // Console.WriteLine(String.Join(" ", secondFliteredList));
            Console.WriteLine(String.Join(" ", result));
            
        } 

        public static int CommonMinLenght(List<int> firstList, List<int> secondList)
        {
            int minLenghtfirstList = FindMinLenght(firstList);
            int minLenghtsecondList = FindMinLenght(secondList);
            int commonMinLenght = (minLenghtfirstList < minLenghtsecondList)
                                  ? minLenghtfirstList : minLenghtsecondList;

            return commonMinLenght;
        }

        private static int FindMinLenght(List<int> tempList)
        {
            int minLenght = int.MaxValue;
            for (int i = 0; i < tempList.Count; i++)
            {
                if (minLenght > FindNumberLenght(tempList[i]))
                {
                    minLenght = FindNumberLenght(tempList[i]);
                }
            }
            return minLenght;
        }

        private static int FindNumberLenght(int number)
        {
            int digitCount = 0;
            while (Math.Abs(number) > 0)
            {
                digitCount++;
                number /= 10;
            }
            return digitCount;
        }
    }
}



