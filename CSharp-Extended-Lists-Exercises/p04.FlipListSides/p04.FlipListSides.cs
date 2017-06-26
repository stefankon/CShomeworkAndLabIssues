using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<int> mainList = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();

            List<int> tempList = new List<int>(mainList);

            InputReversElemets(mainList, tempList);
            AddTerminalElements(mainList, tempList);

            Console.WriteLine(String.Join(" ", tempList));
        }

        static void InputReversElemets(List<int> mainLst, List<int> tempList)
        {
            tempList.Reverse();
        }

        static void AddTerminalElements(List<int> mainLst, List<int> tempList)
        {
            tempList[0] = mainLst[0];
            tempList[tempList.Count - 1] = mainLst[mainLst.Count - 1];
        }
    }
}
