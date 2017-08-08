using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p01.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+ [A-Z][a-z]+)\b";
            string text = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(text, pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
