using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, int> supermarket = new Dictionary<string, int>();
            
            while (inputLine != "shopping time")
            {

               var tokens = inputLine.Split();
               var product = tokens[1];
               var quantity = int.Parse(tokens[2]);

                if (!supermarket.ContainsKey(product))
                {
                    supermarket[product] = 0;
                }
                supermarket[product] += quantity;
                inputLine = Console.ReadLine();

            }
            
            inputLine = Console.ReadLine();

            while (inputLine != "exam time")
            {
                var tokens = inputLine.Split();
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!supermarket.ContainsKey(product))
                {
                    Console.WriteLine($"{ product} doesn't exist");
                }
                else
                {
                    if (supermarket[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        supermarket[product] -= quantity;
                        if (supermarket[product] <= 0)
                        {
                            supermarket[product] = 0;
                        }
                    }
                }
                inputLine = Console.ReadLine();
            }


            foreach (KeyValuePair<string, int> item in supermarket)
            {
                string productToPrint = item.Key;
                int quantityTotal = item.Value;
                if (quantityTotal > 0)
                {
                    Console.WriteLine("{0} -> {1}", productToPrint, quantityTotal);
                }
            }
        }
    }
}

