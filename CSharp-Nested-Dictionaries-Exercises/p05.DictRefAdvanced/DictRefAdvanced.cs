using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.DictRefAdvanced
{
    class DictRefAdvanced
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Dictionary<string, List<int>> dictRefAdvanced = new Dictionary<string, List<int>>();
            List<int> listNumbers = new List<int>();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                                .Split(new string[] { " -> ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string sameName = tokens[1];

                List<int> newData = new List<int>();
                for (int i = 1; i < tokens.Length; i++)
                {
                    int addNum = 0;
                    if (int.TryParse(tokens[i], out addNum))
                    {
                        listNumbers.Add(addNum);
                        if (!dictRefAdvanced.ContainsKey(name))
                        {
                            dictRefAdvanced[name] = new List<int>();
                        }
                        dictRefAdvanced[name].Add(addNum);
                    }

                    else
                    {
                        
                        if (dictRefAdvanced.ContainsKey(sameName))
                        {
                            string newName = tokens[0];
                            newData = dictRefAdvanced[sameName].ToList();
                            dictRefAdvanced[newName] = newData;
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in dictRefAdvanced)
            {
                string currentName = kvp.Key;
                List<int> currentNums = kvp.Value;
                Console.WriteLine($"{currentName} === {string.Join(", ", currentNums)}");
            }
        }
    }
}
