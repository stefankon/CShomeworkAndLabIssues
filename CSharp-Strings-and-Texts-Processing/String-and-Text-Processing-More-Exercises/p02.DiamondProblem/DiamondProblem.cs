using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.DiamondProblem
{
    class DiamondProblem
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int leftIndex = -1;
            int rightIndex = -1;
            bool isFound = false;

            while ((leftIndex = input.IndexOf('<', leftIndex + 1)) > -1
                    && (rightIndex = input.IndexOf('>', leftIndex + 1)) > -1) 
            {
                string diamodContent = input.Substring(leftIndex, rightIndex - leftIndex + 1);
                int carats = FindCarats(diamodContent);
                Console.WriteLine($"Found {carats} carat diamond");
                isFound = true;
            }

            if (!isFound)
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int FindCarats(string diamodContent)
        {
            int carats = 0;
            foreach (char @char in diamodContent)
            {
                if (char.IsDigit(@char))
                {
                    carats += int.Parse(@char.ToString());
                }
            }

            return carats;
        }
    }
}
