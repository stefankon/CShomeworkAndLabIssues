using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join("", Encrypt(input)));
        }

        static string[] Encrypt(int input)
        {
            string[] result = new string[input];

            for (int i = 0; i < input; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                byte charToByte = (byte)(symbol);
                byte firstDigit = 0;
                byte lastDigit = 0;

                if (charToByte < 100)
                {
                    firstDigit = (byte)(charToByte / 10);
                    lastDigit = (byte)(charToByte % 10);
                }
                else
                {
                    firstDigit = (byte)(charToByte / 100);
                    lastDigit = (byte)(charToByte % 10);
                }

                string middlePart = firstDigit.ToString() + lastDigit.ToString();

                result[i] += (char)(charToByte + lastDigit) + middlePart + (char)(charToByte - firstDigit);
            }

            return result;
        }
    }
}
