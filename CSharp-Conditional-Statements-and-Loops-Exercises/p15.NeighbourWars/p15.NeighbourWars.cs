using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 1;
            string peshoAttack = "Pesho used Roundhouse kick and reduced Gosho to";
            string goshoAttack = "Gosho used Thunderous fist and reduced Pesho to";

            while (true)
            {

                if (round % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (peshoHealth > 0 && goshoHealth > 0)
                    {
                        Console.WriteLine($"{peshoAttack} {goshoHealth} health.");
                    }
                }
                else if (round % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0 && goshoHealth > 0)
                    {
                        Console.WriteLine($"{goshoAttack} {peshoHealth} health.");
                    }

                }

                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    break;
                }
                else if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    break;
                }
                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                round++;

            }
        }
    }
}
