using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.RemoveElementsOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWord = Console.ReadLine().Split(' ').ToList();

            for (int i = 1; i < inputWord.Count; i += 2)
            {
                Console.Write(inputWord[i]);
            }
            Console.WriteLine();
        }
    }
}
