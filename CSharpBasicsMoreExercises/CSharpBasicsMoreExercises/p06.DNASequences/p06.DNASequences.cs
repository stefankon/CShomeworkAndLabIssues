using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            char[] nucleotides = {'\0','A','C','G','T'};
           
            

            for (int cn1 = 1; cn1 <= 4; cn1++)
            {
                for (int cn2 = 1; cn2 <= 4; cn2++)
                {
                    for (int cn3 = 1; cn3 <= 4; cn3++)
                    {
                        char borderSymbol = 'X';
                        if (cn1 + cn2 + cn3 >= input)
                        {
                            borderSymbol = 'O';
                        }

                        Console.Write(borderSymbol);
                        Console.Write(nucleotides[cn1]);
                        Console.Write(nucleotides[cn2]);
                        Console.Write(nucleotides[cn3]);
                        Console.Write(borderSymbol);
                        Console.Write(' ');
                        
                    }
                    Console.WriteLine();
                }
               

            }
            

        }
    }
}
