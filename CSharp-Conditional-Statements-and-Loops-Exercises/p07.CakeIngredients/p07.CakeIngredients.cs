using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredient = Console.ReadLine().Trim();
            var counter = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ingredient = Console.ReadLine().Trim();
                counter++;

            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");
            
        }
    }
}

