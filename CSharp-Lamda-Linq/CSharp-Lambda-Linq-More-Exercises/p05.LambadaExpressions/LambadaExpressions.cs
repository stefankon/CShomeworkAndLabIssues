using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.LambadaExpressions
{
    class LambadaExpressions
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Lambada> data = new Dictionary<string, Lambada>();

            while (input != "lambada")
            {
                string[] tokens = input
                                    .Split(new string[] { " => ", "." },
                                           StringSplitOptions.RemoveEmptyEntries)
                                                   .ToArray();


                List<string> selectorObject = new List<string>();
                if (input != "dance")
                {
                    string selector = tokens[0];
                    selectorObject.Add(tokens[1]);
                    string property = tokens[2];

                    if (!data.ContainsKey(selector))
                    {
                        data.Add(selector, new Lambada(selector, selectorObject, property));
                    }

                    if (data.ContainsKey(selector))
                    {
                        data[selector] = new Lambada(selector, selectorObject, property);
                    }
                }

                if (input == "dance")
                {
                    foreach (var lambada in data)
                    {
                        var lm = lambada.Value;
                        string selector = lm.Selector;
                        var selectorObj = lm.SelectorObject;

                        if (data.ContainsKey(selector))
                        {
                            selectorObj.Add(selector);
                        }
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var lmb in data)
            {
                var currLambda = lmb.Value;
                Console.Write($"{currLambda.Selector} => ");
                for (int i = 0; i < currLambda.SelectorObject.Count; i++)
                {
                    Console.Write($"{currLambda.SelectorObject[i]}.");
                }
                Console.WriteLine(currLambda.Proterty);
            }
        }
    }

    class Lambada
    {
        public string Selector { get; set; }
        public List<string> SelectorObject { get; set; }
        public string Proterty { get; set; }

        public Lambada(string selctor, List<string> selectorObject, string property)
        {
            this.Selector = selctor;
            this.SelectorObject = selectorObject;
            this.Proterty = property;
        }
    }
}