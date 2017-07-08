using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> insertingList = new List<int>();

            for (int i = 0; i < number; i++)
            {
                InsertNumbers(insertingList);
                RemoveNumbers(insertingList);
            }
            Console.WriteLine(string.Join(" ", insertingList));
        }

        private static void RemoveNumbers(List<int> insertingList)
        {
            for (int i = 0; i < insertingList.Count - 1; i++)
            {
                if (insertingList[i] > insertingList[i + 1])
                {
                    for (int removed = i + 1; removed < insertingList.Count; removed++)
                    {
                        insertingList.RemoveAt(removed);
                        removed--;
                    }
                }
            }
        }

        private static void InsertNumbers(List<int> insertingList)
        {
            List<int> currentNumber = Console.ReadLine().Split(' ')
                                        .Select(int.Parse).ToList();

            if ((insertingList.Count == 0) || 
                (insertingList[insertingList.Count - 1] <= currentNumber[0]))
            {
                foreach (var item in currentNumber)
                {
                    insertingList.Add(item);
                }
            }
            else
            {
                int positionStart = 0;
                for (int i = 0; i < insertingList.Count; i++)
                {
                    if (insertingList[i] > currentNumber[0])
                    {
                        positionStart = i;
                        break;
                    }
                }

                var positionEnd = positionStart + currentNumber.Count;
                var count = 0;
                for (int position = positionStart; position < positionEnd; position++)
                {
                    insertingList.Insert(position, currentNumber[count]);
                    count++;
                    if (insertingList[position] > insertingList[position + 1])
                    {
                        break;
                    }
                }
            }
        }
    }
}
