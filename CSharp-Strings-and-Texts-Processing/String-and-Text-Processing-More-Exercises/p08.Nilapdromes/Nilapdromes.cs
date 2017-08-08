﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string nilapdrome = ReturnNilapdrome(line);
                if (nilapdrome != "")
                {
                    Console.WriteLine(nilapdrome);
                }

                line = Console.ReadLine();
            }
        }

        private static string ReturnNilapdrome(string line)
        {
            int middleIndex = line.Length / 2;
            int leftIndex = 0;
            string border = "";

            for (int i = middleIndex + 1; i < line.Length; i++)
            {
                if (line[leftIndex] == line[i])
                {
                    border += line[i];
                    leftIndex++;
                }
                else
                {
                    border = "";
                    leftIndex = 0;
                    if (line[i] == line[leftIndex])
                    {
                        border += line[i];
                        leftIndex++;
                    }
                }
            }
           

            if (border != "")
            {
                int leftIndexMiddle = line.IndexOf(border);
                int rightIndexMiddle = line.LastIndexOf(border);
                string middle = line.Substring(leftIndexMiddle + border.Length,
                                                rightIndexMiddle - leftIndexMiddle - border.Length);

                if (middle != "")
                {
                    return middle + border + middle;
                }
            }


            return "";
        }
    }
}
