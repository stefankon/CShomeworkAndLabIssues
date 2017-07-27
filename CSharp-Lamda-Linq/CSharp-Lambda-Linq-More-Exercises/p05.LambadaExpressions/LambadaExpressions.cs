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
            int counter = 1;

            while (input != "lambada")
            {
                string[] tokens = input
                                    .Split(new string[] { " => ", "." },
                                           StringSplitOptions.RemoveEmptyEntries)
                                                   .ToArray();
                string selector = tokens[0];
                string selObj = "";
                string property = "";
                string secondSelector = "";
               
                List<string> selectorObject = new List<string>();
                if (selector != "dance")
                {
                    secondSelector = selector;
                    property = tokens[2];
                    selObj = tokens[1];
                    selectorObject.Add(selObj);
                    if (!data.ContainsKey(secondSelector))
                    {
                        data.Add(secondSelector, new Lambada(secondSelector, selectorObject, property));
                    }
                }
                if (data.ContainsKey(secondSelector))
                {
                    data[secondSelector] = new Lambada(secondSelector, selectorObject, property);
                }
                if (selector == "dance")
                {
                    counter++;
                }

                input = Console.ReadLine();
            }
            foreach (var lmb in data)
            {
                var currLambda = lmb.Value;
                Console.Write($"{currLambda.Selector} => ");
                for (int i = 0; i < counter; i++)
                {
                    Console.Write($"{currLambda.SelectorObject[0]}.");
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
