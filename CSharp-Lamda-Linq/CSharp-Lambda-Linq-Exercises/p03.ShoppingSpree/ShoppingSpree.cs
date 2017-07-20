using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.ShoppingSpree
{
    class ShoppingSpree
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Dictionary<string, double> products = new Dictionary<string, double>();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                double price = double.Parse(tokens[1]);

                
                if (products.ContainsKey(product))
                {
                    if (products[product] > price)
                    {
                        products[product] = price;
                    }
                }
                else
                {
                    products[product] = price;
                }
                
                input = Console.ReadLine();
            }
            var totalSum = products.Select(s => s.Value).Sum();
            var sortedPruducts = products
                                 .OrderBy(k => k.Key.Length)
                                 .OrderByDescending(p => p.Value);

            if (budget >= totalSum)
            {
                foreach (var kvp in sortedPruducts)
                {
                    Console.WriteLine($"{kvp.Key} costs {kvp.Value:F2}");
                }
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            
        }
    }
}
