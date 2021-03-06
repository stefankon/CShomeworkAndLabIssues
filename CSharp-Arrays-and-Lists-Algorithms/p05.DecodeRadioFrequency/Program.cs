﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.DecodeRadioFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder left = new StringBuilder();
            StringBuilder right = new StringBuilder();
            foreach (string item in input)
            {
                int dotIndex = DotIndex(item);
                char leftChar = (char)int.Parse(item.Substring(0, dotIndex));
                char rightChar = (char)int.Parse(item.Substring(dotIndex + 1));
                if (leftChar != 0)
                {
                    left.Append(leftChar);
                }
                if (rightChar != 0)
                {
                    right.Append(rightChar);
                }
            }
            string output = left.ToString() + new string(right.ToString().Reverse().ToArray());
            Console.WriteLine(output);
        }

        private static int DotIndex(string item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (item[i] == '.')
                {
                    return i;
                }
            }
            throw new Exception("No dot found");
        }
    }
}
