using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08.SMSTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCnt = int.Parse(Console.ReadLine());

            string textToPrint = String.Empty;

            for (int cnt = 0; cnt < inputCnt; cnt++)
            {
                string input = Console.ReadLine();
                int currentDigit = 0;

                if (input.Length >= 1)
                {
                    currentDigit = input[0] - '0';
                    if (currentDigit == 0)
                    {
                        textToPrint = textToPrint + (' ');

                    }

                }
                else
                {
                    Debug.Assert(false);
                }

                int charIndex = (char)(currentDigit - 2) * 3 + (input.Length - 1);
                if (currentDigit == 8 || currentDigit == 9)
                {
                    charIndex += 1;
                }

                textToPrint += ((char)(charIndex + 'a'));

            }

            Console.WriteLine("{0}", textToPrint.Remove('['));
        }
    }
}

