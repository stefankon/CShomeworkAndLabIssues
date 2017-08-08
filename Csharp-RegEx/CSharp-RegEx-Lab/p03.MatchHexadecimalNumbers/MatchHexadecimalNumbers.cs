using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            string hexNumbers = Console.ReadLine();

            string[] numbers = Regex.Matches(hexNumbers, pattern)
                               .Cast<Match>()
                               .Select(a => a.Value)
                               .ToArray();

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
