using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.StringDecryption
{
    class StringDecryption
    {
        static void Main(string[] args)
        {
            int[] selection = Console.ReadLine()
                              .Split(' ')
                              .Select(int.Parse)
                              .ToArray();
            int[] letters = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
                 
            int elementSkip = selection[0];
            int elementTake = selection[1];

            int[] text = letters
                                 .Where(x => x >= 65 && x <= 90)
                                 .ToArray();

            int[] filteredText = text
                                .Skip(elementSkip)
                                .Take(elementTake)
                                .ToArray();

            foreach (var lt in filteredText)
            {
                Console.Write((char)lt);
            }
            Console.WriteLine();
        }
    }
}
