using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.ExactProductRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numProducs = int.Parse(Console.ReadLine());
            decimal productPrice = 0.0M;
            decimal totalPrice = 1M;



            for (int i = 0; i < numProducs; i++)
            {
                productPrice = decimal.Parse(Console.ReadLine());
                totalPrice *= productPrice;

            }

           // string result = totalPrice.ToString().Trim('0').Trim('.');
            Console.WriteLine($"{totalPrice}");

        }
    }
}
