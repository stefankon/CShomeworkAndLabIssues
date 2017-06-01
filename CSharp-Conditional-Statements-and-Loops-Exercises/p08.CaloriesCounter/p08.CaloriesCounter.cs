using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredientNum = int.Parse(Console.ReadLine());
            var calories = 0;
            var ingredient = String.Empty;

            for (int i = 0; i < ingredientNum; i++)
            {
                ingredient = Console.ReadLine().ToLower().Trim();

                switch (ingredient)
                {
                    case "cheese":
                        calories += 500;
                        break;
                    case "tomato sauce":
                        calories += 150;
                        break;
                    case "salami":
                        calories += 600;
                        break;
                    case "pepper":
                        calories += 50;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
