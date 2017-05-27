using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.CharacterStars
{
    class CharacterStars
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHelt = int.Parse(Console.ReadLine());
            int maximumtHelt = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            int heltDots = maximumtHelt - currentHelt;
            int energyDots = maximumEnergy - currentEnergy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', currentHelt) + new string('.', heltDots) + "|");
            Console.WriteLine("Energy: |" + new string('|', currentEnergy) + new string('.', energyDots) + "|");

        }
    }
}
