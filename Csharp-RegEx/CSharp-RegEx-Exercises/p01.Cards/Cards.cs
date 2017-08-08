using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p01.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            string regex = @"([0-9]+)([SHDC])|([JQKA][SHDC])";

            string input = Console.ReadLine();

            MatchCollection cards = Regex.Matches(input, regex);

            List<Match> allCards = new List<Match>();
           

            foreach (Match card in cards)
            {
                int number = 0;
                if (int.TryParse(card.Groups[1].Value, out number))
                {
                    if (number < 2 || number > 10)
                    {
                        continue;
                    }
                   
                }
                allCards.Add(card);
            }

            Console.WriteLine(string.Join(", ", allCards));
        }
    }
}