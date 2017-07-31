using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input
                                  .Split(new string[] { " -> " },
                                        StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                string textToPrint = tokens[0];

                List<string> delimiters = tokens[1]
                                            .Split(new string[] { ", " },
                                                StringSplitOptions.RemoveEmptyEntries)
                                                    .ToList();

                for (int cnt = 0; cnt < delimiters.Count; cnt++)
                {
                    textToPrint = textToPrint.Replace($"{{{cnt}}}", delimiters[cnt]);
                }
                Console.WriteLine(textToPrint);
                delimiters.Clear();
                input = Console.ReadLine();

            }
        }
    }
}
