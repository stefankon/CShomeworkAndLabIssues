using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine().Split(' ');

            Random rnd = new Random();
            for (int pos1 = 0; pos1 < inputLine.Length; pos1++)
            {
                int int2 = rnd.Next(inputLine.Length);
                
            }
        }
    }
}
