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

                if (!data.ContainsKey(input.Type) && !data.ContainsKey("flatten"))
                {
                    data.Add(input.Type, new Dictionary<string, string>());
                }
                if (!data[input.Type].ContainsKey(input.Mark))
                {
                    data[input.Type].Add(input.Mark, input.Model);
                }
                if (data.ContainsKey("flatten"))
                {
                    var newType = input.Mark;
                    while (inputLine != "end")
                    {
                        inputLine = Console.ReadLine();
                        var concat = input.Mark + input.Model + "";
                        var emptyStr = input.Mark;
                        if (data.ContainsKey(newType))
                        {
                            if (data.ContainsKey(newType))
                            {
                                data[newType] = new Dictionary<string, string>();
                                if (!data[newType].ContainsKey(concat))
                                {
                                    data[newType].Add(concat, emptyStr);
                                }
                            }
                        }
                        if (inputLine == "end")
                        {
                            return;
                        }
                    }
                }

                inputLine = Console.ReadLine();


            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"{item2.Key} >>> {item2.Value}");
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

