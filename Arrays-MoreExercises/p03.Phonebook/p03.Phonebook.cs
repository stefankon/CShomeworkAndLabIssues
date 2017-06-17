using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currentPhoneNumber = Console.ReadLine().Split(' ');
            string[] currentName = Console.ReadLine().Split(' ');

            string currentInput;
            do
            {
                currentInput = Console.ReadLine();
                for (int cnt = 0; cnt < currentName.Length; cnt++)
                {

                    if (currentInput == currentName[cnt])
                    {
                        Console.WriteLine("{0} -> {1}", currentName[cnt], currentPhoneNumber[cnt]);
                    }
                }

            } while (currentInput != "done");

        }
    }
}
