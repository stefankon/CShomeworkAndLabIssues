using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.CamelsBack
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> buildings = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();

            int camelBack = int.Parse(Console.ReadLine());
            int round = (((int)buildings.Count) - camelBack) / 2;

            List<int> remaining = new List<int>();
            for (int cnt = (round); cnt < (buildings.Count - round); cnt++)
            {
                remaining.Add(buildings[cnt]);
            }

            if (round != 0)
            {
                Console.WriteLine($"{round} rounds");
                Console.Write("remaining: ");
                Console.WriteLine(String.Join(" ", remaining));
            }
            else
            {
                Console.Write("already stable: ");
                Console.WriteLine(String.Join(" ", remaining));
            }
            
        }
    }
}
