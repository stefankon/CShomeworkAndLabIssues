using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.SentenceSplit
{
    class SentenceSplit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string[] splitedText = input
                                    .Split(new string[] { delimiter },
                                        StringSplitOptions.None);

            Console.Write("[");
            Console.Write(string.Join(", ", splitedText));
            Console.WriteLine("]");

        }
    }
}
