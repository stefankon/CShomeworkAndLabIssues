using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeatSting = Console.ReadLine();
            int counter = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(repeatSting, counter));
            
        }

        static string RepeatString(string str, int count)
        {
            string repeatString = String.Empty;
            for (int cnt = 0; cnt < count; cnt++)
            {
                repeatString += str;
            }
            return repeatString;
        }
    }
}
