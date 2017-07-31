using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.JSONStringify
{
    class JSONStrigify
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();

            text.Append("[");
            while (input != "stringify")
            {
                string[] tokens = input
                                    .Split(new string[] { " : ", " ->"},
                                        StringSplitOptions.RemoveEmptyEntries)
                                             .ToArray();
                string name = tokens[0];
                string age = tokens[1];
                string grades = "";

                if (tokens.Length > 2)
                {
                    grades = tokens[2].Substring(1, tokens[2].Length - 1);
                }
                //Console.WriteLine(string.Join("<>", tokens));
                text.Append($"{{name:\"{name}\",age:{age},grades:[{grades}]}}");
                input = Console.ReadLine();
                if (input != "stringify")
                {
                    text.Append(",");
                }
               
            }
            text.Append("]");

           
            Console.WriteLine(text);
        }
    }
}
