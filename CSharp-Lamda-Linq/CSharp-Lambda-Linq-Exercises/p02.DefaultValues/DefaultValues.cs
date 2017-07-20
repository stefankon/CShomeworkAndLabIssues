using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var dataList = new Dictionary<string, string>();

            while (inputLine != "end")
            {
                string[] tokens = ParesTokens(inputLine);
                var mainKey = tokens[0];
                var firstValue = tokens[1];


                StoreData(dataList, mainKey, firstValue);
                
                inputLine = Console.ReadLine();
            }
            var replaceValue = Console.ReadLine();

            var sortedData = dataList
                .Where(r => r.Value != "null")
                .OrderByDescending(r => r.Value.Length);

            var replacedValues = dataList
                                .Where(k => k.Value == "null")
                                .Select(k => new KeyValuePair<string, string>(k.Key, replaceValue))
                                .ToDictionary(k => k.Key, k => k.Value);
        

            foreach (var kvp in sortedData)
            {
                var printKey = kvp.Key;
                var printValue = kvp.Value;
                Console.WriteLine($"{printKey} <-> {printValue}");
            }
            foreach (var kvp in replacedValues)
            {
                var printKey = kvp.Key;
                var printValue = kvp.Value;
                Console.WriteLine($"{printKey} <-> {printValue}");
            }
        }
        
        private static void StoreData(
                               Dictionary<string, string> dataList,
                               string mainKey,
                               string firstValue)
        {
            if (!dataList.ContainsKey(mainKey))
            {
                dataList[mainKey] = "";
            }
            dataList[mainKey] = firstValue;
        }

        private static string[] ParesTokens(string inputLine)
        {
            return inputLine
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
