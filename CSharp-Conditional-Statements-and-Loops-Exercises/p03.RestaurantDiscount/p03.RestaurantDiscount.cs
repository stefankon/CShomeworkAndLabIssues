using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {

            var group = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hall = String.Empty;
            var price = 0.0;

            if (group <= 50)
            {
                hall = "Small Hall";
                price += 2500;
            }
            else if (group <= 100)
            {
                hall = "Terrace";
                price += 5000;
            }
            else if (group <= 120)
            {
                hall = "Great Hall";
                price += 7500;
            }
            else
            {
                Console.Write("We do not have an appropriate hall.");
            }

            switch (package)
            {
                case "Normal":
                    price += 500;
                    break;
                case "Gold":
                    price += 750;
                    break;
                case "Platinum":
                    price += 1000;
                    break;
                default:
                    break;
            }

            if (group <= 120)
            {
                if (package == "Normal")
                {
                    price = price - (price * 0.05);
                }
                else if (package == "Gold")
                {
                    price = price - (price * 0.10);
                }
                else
                {
                    price = price - (price * 0.15);
                }

                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine("The price per person is {0:F2}$", price / group);
            }

        }
    }
}
