using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15.CountCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string newInput = input.Replace(" ", String.Empty);
            char[] letters = newInput.ToCharArray();

            int counter = 0;

            for (int cnt = 0; cnt < letters.Length; cnt++)
            {

                if ((65 <= letters[cnt]) && (letters[cnt] <= 90))
                {
                    counter++;
                }
                
            }
            Console.WriteLine(counter);
        }
    }
}
