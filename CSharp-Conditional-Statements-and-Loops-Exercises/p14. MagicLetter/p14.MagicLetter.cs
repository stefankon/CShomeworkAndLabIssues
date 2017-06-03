using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char magicLetter = char.Parse(Console.ReadLine());



            for (char firstLetter = startLetter; firstLetter <= endLetter; firstLetter++)
            {
                for (char secondLetter = startLetter; secondLetter <= endLetter; secondLetter++)
                {
                    for (char thirdLetter = startLetter; thirdLetter <= endLetter; thirdLetter++)
                    {
                        string word = firstLetter.ToString() + secondLetter.ToString() + thirdLetter.ToString();
                        if (!word.Contains(magicLetter))
                        {
                            Console.Write(word + " ");
                        }

                        
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
