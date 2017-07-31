using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.JSONParse
{
    class JSONParse
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string parsedString = input.Substring(2, input.Length - 2 - 2);

            List<string> names = parsedString
                                    .Split(new string[] { "},{" },
                                            StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();

            foreach (string name in names)
            {
                string[] tokens = name
                                  .Split(new string[] { ",age:", ",grades:" },
                                       StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();
                string currName = tokens[0].Substring(6, tokens[0].Length - 6 - 1);
                string currAge = tokens[1];
                string currGrades = tokens[2].Substring(1, tokens[2].Length - 1 - 1);
                int index = currGrades.Length;
                if (index == 0)
                {
                    currGrades = "None";
                }

                Console.WriteLine($"{currName} : {currAge} -> {currGrades}");
            }
        }
    }
}
