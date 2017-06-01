using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();

            var product = "";

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

            Console.WriteLine($"{ product}");

        }
    }
}
