using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] temp = text.ToCharArray();
            List<char> reversedText = temp.Reverse().ToList();
           
            Console.WriteLine(string.Join("", reversedText));
        }
    }
}
