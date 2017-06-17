using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            TextToPrintBeginnig();
            Console.Write(name);
            TextToPrintEnd();

        }


        static void TextToPrintBeginnig()
        {

            Console.Write("Hello, ");
        }
        static void TextToPrintEnd()
        {

            Console.WriteLine("!");
        }
    }
}
