using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.TearListHalf
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> mainListInput = Console.ReadLine()
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToList();

            List<int> insertList = new List<int>(mainListInput);
            List<int> tearListHalf = new List<int>();

            int mainCounter = (mainListInput.Count / 2) * 3;
            int counter = 0;

            InsertList(insertList);
            TearListHalf(mainListInput, tearListHalf);

            for (int cnt = 1; cnt <= mainCounter; cnt += 3)
            {
                insertList.Insert(cnt, tearListHalf[counter]);
                counter++;
            }

            Console.WriteLine(String.Join(" ", insertList));


        }

        
        static void TearListHalf(List<int> mainListInput, List<int> tearListHalf)
        {
            
            for (int cnt = 0; cnt < mainListInput.Count / 2; cnt++)
            {
                tearListHalf.Add(mainListInput[cnt]);
            }
        }

        static void InsertList(List<int> insertList)
        {
            List<int> tempList = new List<int>();
            int startNum = (insertList.Count / 2);
            int counter = 0;
            //int counter2 = 0;
            for (int j = startNum; j < insertList.Count; j++)
            {
                tempList.Add(insertList[j]);
            }

            for (int i = 0; i < insertList.Count; i++)
            {

                if (i % 2 == 0)
                {
                    insertList[i] = tempList[counter / 2] / 10;
                }
                // Odd position
                else
                {
                    insertList[i] = tempList[counter / 2] % 10;
                }
                counter++;
            }

        }
    }
}
