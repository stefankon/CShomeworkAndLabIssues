using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p17.CypherRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());
            string message = String.Empty;
            string preeviousString = String.Empty;
            bool isReversed = false;

            for (int cnt = 0; cnt < linesNumber; cnt++)
            {
                string currentString = Console.ReadLine();
                if (currentString == preeviousString)
                {
                    message = String.Empty;
                    if (currentString == "spin")
                    {
                        linesNumber++;
                    }
                    continue;
                }
                if (currentString == "spin")
                {
                    isReversed = !isReversed;
                    linesNumber++;
                }
                else
                {
                    if (isReversed)
                    {
                        message = currentString + message;
                    }
                    else
                    {
                        message += currentString;
                    }

                }

                preeviousString = currentString;
            }
            Console.WriteLine(message);
        }
    }
}
