using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            double outFall4Price = 39.99;
            double csOgPrice = 15.99;
            double zplinterZellPrice = 19.99;
            double honored2Price = 59.99;
            double roverWatchPrice = 29.99;
            double roverWatchOriginsPrice = 39.99;

            double balance = double.Parse(Console.ReadLine());
            double startBalance = balance;
            String input = Console.ReadLine();
            double price = 0;
            String currentGame = String.Empty;

            while (input != "Game Time")
            {

                if (input == "OutFall 4")
                {
                    price = outFall4Price;
                    currentGame = "OutFall 4";

                }
                else if (input == "CS: OG")
                {
                    price = csOgPrice;
                    currentGame = "CS: OG";

                }
                else if (input == "Zplinter Zell")
                {
                    price = zplinterZellPrice;
                    currentGame = "Zplinter Zell";

                }
                else if (input == "Honored 2")
                {
                    price = honored2Price;
                    currentGame = "Honored 2";

                }
                else if (input == "RoverWatch")
                {
                    price = roverWatchPrice;
                    currentGame = "RoverWatch";

                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = roverWatchOriginsPrice;
                    currentGame = "RoverWatch Origins Edition";

                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }

                if (price <= balance)
                {
                    Console.WriteLine("Bought {0}", currentGame);
                    balance -= price;

                }
                else
                {

                    Console.WriteLine("Too Expensive");

                }

                input = Console.ReadLine();
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }


            }
            Console.WriteLine("Total spent: ${0:F2}. Remaining: ${1:F2}", startBalance - balance, balance);

        }
    }
}


