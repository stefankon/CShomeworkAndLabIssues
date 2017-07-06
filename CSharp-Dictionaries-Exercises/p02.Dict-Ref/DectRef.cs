using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.DictRef
{
    class DectRef
    {
        static void Main(string[] args)
        {


            Dictionary<string, int> values = new Dictionary<string, int>();
            string[] tokens = Console.ReadLine()
                               .Split(new char[] { ' ', '=' }, StringSplitOptions
                               .RemoveEmptyEntries);


            while (tokens[0] != "end")
            {
                string keyInput = tokens[0];
                string valueInput = tokens[1];

                int numberValue;

                if (int.TryParse(valueInput, out numberValue))
                {
                    values[keyInput] = numberValue;
                }
                else
                {
                    if (values.ContainsKey(valueInput))
                    {
                        values[keyInput] = values[valueInput];
                    }
                }
                tokens = Console.ReadLine()
                               .Split(new char[] { ' ', '=' }, StringSplitOptions
                               .RemoveEmptyEntries);
            }
            foreach (KeyValuePair<string, int> element in values)
            {
                Console.WriteLine($"{element.Key} === {element.Value}");
            }
        }
    }
}