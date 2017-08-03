using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.ValueOfString
{
    class ValueOfString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string command = Console.ReadLine();
            int result = 0;

            if (command == "LOWERCASE")
            {
                for (int cnt = 0; cnt < text.Length; cnt++)
                {
                    if (char.IsLower(text[cnt]) && char.IsLetter(text[cnt]))
                    {
                        int temp = text[cnt];
                        result += temp;
                    }
                }

            }
            else //if (command == "UPPERCASE")
            {
                for (int cnt = 0; cnt < text.Length; cnt++)
                {
                    if (char.IsUpper(text[cnt]) && char.IsLetter(text[cnt]))
                    {
                        int temp = text[cnt];
                        result += temp;
                    }
                }
            }

            Console.WriteLine($"The total sum is: {result}");

        }
    }
}
