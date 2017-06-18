using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();

            List<string> appendList = new List<string>();


            for (int cnt = 0; cnt < input.Count; cnt++)
            {
                input[cnt] = input[cnt].Trim();
                appendList.Add(input[cnt]);
               
            }

            appendList.Reverse();
            Console.WriteLine(string.Join(" ", appendList));
        }
    }
}
