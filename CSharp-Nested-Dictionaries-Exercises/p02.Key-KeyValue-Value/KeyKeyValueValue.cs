using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.Key_KeyValue_Value
{
    class KeyKeyValueValue
    {
        static void Main(string[] args)
        {
            string inputKey = Console.ReadLine();
            string inputValue = Console.ReadLine();
            int numLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> keyList = new Dictionary<string, List<string>>();

            for (int cnt = 0; cnt < numLines; cnt++)
            {
                string[] tokens = Console.ReadLine()
                                .Split(new string[] { " => ", ";" }, StringSplitOptions.RemoveEmptyEntries);

                var currentKey = tokens[0];

                for (int cnt1 = 1; cnt1 < tokens.Length; cnt1++)
                {
                    if (!keyList.ContainsKey(currentKey))
                    {
                        keyList[currentKey] = new List<string>();
                    }
                    keyList[currentKey].Add(tokens[cnt1]);
                }


            }
            foreach (var kvp in keyList)
            {
                var keyToPrint = kvp.Key;
                var valueToPrint = kvp.Value;

                bool existsKey = keyToPrint
                                .IndexOf(inputKey, StringComparison.Ordinal) > -1;
                if (existsKey)
                {
                    Console.WriteLine("{0}:",keyToPrint);
                    for (int cnt3 = 0; cnt3 < valueToPrint.Count; cnt3++)
                    {
                        bool existsValue = valueToPrint[cnt3]
                                           .IndexOf(inputValue, StringComparison.Ordinal) > -1;
                        if (existsValue)
                        {
                            Console.Write("-{0}", valueToPrint[cnt3]);
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
