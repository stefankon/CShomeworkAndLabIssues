using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> data = new Dictionary<string, int>();

            while (input != "chop chop")
            {
                ScraperData inputLine = ScraperData.ParseTokens(input);

                if (!data.ContainsKey(inputLine.Type))
                {
                    data.Add(inputLine.Type, inputLine.Measure);
                }
                data.Add(inputLine.Type, inputLine.Measure);
                input = Console.ReadLine();
            }
            string usedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());

            double price = Math.Round(data.Average(x => x.Value), 2);
            double used = data.Where(x => x.Key == usedType && x.Value >= minHeight).Sum(x => x.Value);
            double unused = data.Where(x => x.Key != usedType || x.Value < minHeight).Sum(x => x.Value);

            used *= price;
            unused *= (price * 0.25);

            used = Math.Round(price, 2);
            unused = Math.Round(unused, 2);
            double totalPrice = Math.Round(used + unused, 2);

            Console.WriteLine("Price per meter: ${0:F2}", logPrice);
            Console.WriteLine("Used logs price: ${0:F2}", usedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:F2}", unusedLogsPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:F2}", totalPrice);

        }
    }
    class ScraperData
    {
        //private int points;

        public ScraperData(string type, int measure)
        {

            Type = type;
            Measure = measure;
        }

        public string Type { get; set; }

        public int Measure { get; set; }

        public static ScraperData ParseTokens(string input)
        {
            string[] tokens = input
                            .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            var type = tokens[0];
            var measure = int.Parse(tokens[1]);

            return new ScraperData(type, measure);

        }
    }
}
