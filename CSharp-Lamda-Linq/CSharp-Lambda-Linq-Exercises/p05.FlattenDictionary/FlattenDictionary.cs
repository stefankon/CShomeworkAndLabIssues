using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.FlattenDictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, Dictionary<string, string>> data =
                                        new Dictionary<string, Dictionary<string, string>>();

            while (inputLine != "end")
            {
                DataStore input = DataStore.ParseTokens(inputLine);

                if (input.Type != "flatten")
                {
                    if (!data.ContainsKey(input.Type))
                    {
                        data.Add(input.Type, new Dictionary<string, string>());
                    }
                    data[input.Type][input.Mark] = input.Model;
                }
                else
                {
                    var newType = input.Mark;
                    data[newType] =
                        data[newType].ToDictionary(x => x.Key + x.Value, x => "flat");
                }

                inputLine = Console.ReadLine();
            }
            var orderedData = data
                .OrderByDescending(r => r.Key.Length)
                .ToDictionary(r => r.Key, r => r.Value);

            foreach (var kvp1 in orderedData)
            {
                var key = kvp1.Key;
                var innerKey = kvp1.Value;
                Console.WriteLine(key);
                var notFlat = innerKey.Where(x => x.Value != "flat").OrderBy(x => x.Key.Length);

                var isFlat = innerKey.Where(x => x.Value == "flat");

                int counter = 1;
                foreach (var kvp2 in notFlat)
                {
                    Console.WriteLine($"{counter}. {kvp2.Key} - {kvp2.Value}");
                    counter++;
                }
                foreach (var kvp3 in isFlat)
                {
                    Console.WriteLine($"{counter}. {kvp3.Key}");
                    counter++;
                }
            }

           
            

        }
    }

    class DataStore
    {
        private string concatenated;

        public DataStore(string type, string mark, string model)
        {
            Type = type;
            Mark = mark;
            Model = model;
        }

        public DataStore(string concatenated)
        {
            this.concatenated = concatenated;
        }

        public string Type { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }

        public static DataStore ParseTokens(string input)
        {
            string[] tokens = input
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            var type = "";
            var mark = "";
            var model = "";
            if (tokens.Length > 2)
            {
                type = tokens[0];
                mark = tokens[1];
                model = tokens[2];
            }
            else
            {
                type = tokens[0];
                mark = tokens[1];
                model = "";
            }


            return new DataStore(type, mark, model);

        }
        public static DataStore Flatten(string mark, string model)
        {
            var concatenated = mark + model;
            return new DataStore(concatenated);
        }
    }
}

