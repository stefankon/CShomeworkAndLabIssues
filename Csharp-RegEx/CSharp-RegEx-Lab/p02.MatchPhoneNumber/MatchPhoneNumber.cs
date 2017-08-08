using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace p02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|[\s])\+359([\s-])2\2([0-9]{3})\2([0-9]{4})\b";

            string phoneNum = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phoneNum, pattern);

            // var result = phoneMatches
            //              .Cast<Match>()
            //              .Select(a => a.Value.Trim())
            //              .ToArray();
            
            for (int i = 0; i < phoneMatches.Count; i++)
            {
                string currN = phoneMatches[i].Value.Trim().ToString();
                if (i != phoneMatches.Count - 1)
                {
                    Console.Write(currN + ", ");
                }
                else
                {
                    Console.WriteLine(currN);
                }

            }
           // Console.WriteLine();
        }
    }
}
