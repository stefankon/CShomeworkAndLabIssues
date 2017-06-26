using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp
{
    class Temp
    {
        static void Main(string[] args)
        {
            string currentInput = Console.ReadLine();
            int numberToInsert = int.Parse(currentInput);
            string indexArr = currentInput[0].ToString();
            int index = int.Parse(indexArr);

            // mainList.Insert(index, numberToInsert);
            //currentInput = Console.ReadLine();
            Console.WriteLine($"*{numberToInsert}");
            Console.WriteLine($"**{index}");
        }
    }
}
