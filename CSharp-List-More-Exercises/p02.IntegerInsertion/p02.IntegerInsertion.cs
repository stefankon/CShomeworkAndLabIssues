using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mainList = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();

            string currentInput = Console.ReadLine();
            while (currentInput != "end")
            {
                int numberToInsert = int.Parse(currentInput);
                string indexArr = currentInput[0].ToString();
                int index = int.Parse(indexArr);

                mainList.Insert(index, numberToInsert);
                currentInput = Console.ReadLine();

            }
            Console.WriteLine(String.Join(" ", mainList));
        }
    }
}

