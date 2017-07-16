using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> tokens = new List<string>();
            tokens = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine(string.Join("/ ", tokens));
        }
    }
}
