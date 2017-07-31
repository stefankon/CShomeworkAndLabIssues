using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.FindTheLetter
{
    class FindTheLetter
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] parameters = Console.ReadLine()
                                    .Split(' ')
                                        .ToArray();

            var letterToFind = parameters[0];
            int numOccured = int.Parse(parameters[1]);
            int indexToFind = 0;
            int index = 0;

            
            for (int i = 0; i < numOccured; i++)
            {
                indexToFind = text.IndexOf(letterToFind, index);
                index = indexToFind + 1;
            }
            if (indexToFind != - 1)
            {
                Console.WriteLine(indexToFind);
            }

            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        
        }
    }
}
