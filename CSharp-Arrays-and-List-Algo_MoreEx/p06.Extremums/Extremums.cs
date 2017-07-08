using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.Extremums
{
    class Extremums
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split(' ')
                                .Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            bool isMin = false;
            if (command == "min")
            {
                isMin = true;
            }
            else
            {
                isMin = false;
            }

            int[] extremeNums = inputNumbers.Select(a => FindExtreme(a, isMin)).ToArray();
            Console.WriteLine(string.Join(", ", extremeNums));
            Console.WriteLine(extremeNums.Sum());

        }
        private static int FindExtreme(int a, bool isMin)
        {
            int extreme = a;
            int digits = GetDigits(a);
            for (int i = 0; i < digits; i++)
            {
                string aText = a.ToString();
                int rotated = int.Parse(RotateNumber(a, i));
                if (isMin && rotated < extreme)
                {
                    extreme = rotated;
                }
                else if (!isMin && rotated > extreme)
                {
                    extreme = rotated;
                }
            }
            return extreme;
        }

        private static string RotateNumber(int a, int times)
        {
            List<char> digits = a.ToString().ToList();
            for (int i = 0; i < times; i++)
            {
                char first = digits[0];
                digits.RemoveAt(0);
                digits.Add(first);
            }
            return string.Join("", digits);
        }

        private static int GetDigits(int a)
        {
            int counter = 0;
            while (a > 0)
            {
                a /= 10;
                counter++;
            }
            return counter;
        }
    }
}
