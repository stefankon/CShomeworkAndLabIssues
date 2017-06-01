using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.ChooseDrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            var product = "";
            var price = 0.0;

            switch (profession)
            {
                case "Athlete":
                    product = "Water";
                    break;
                case "Businessman":
                    product = "Coffee";
                    break;
                case "Businesswoman":
                    product = "Coffee";
                    break;
                case "SoftUni Student":
                    product = "Beer";
                    break;
                default:
                    product = "Tea";
                    break;
            }

            switch (product)
            {
                case "Water":
                    price = 0.70;
                    break;
                case "Coffee":
                    price = 1.00;
                    break;
                case "Beer":
                    price = 1.70;
                    break;
                case "Tea":
                    price = 1.20;
                    break;
                default:
                    break;
            }
            var total = quantity * price;

            Console.WriteLine("The {0} has to pay {1:F2}.", profession, total);
        }
    }
}
