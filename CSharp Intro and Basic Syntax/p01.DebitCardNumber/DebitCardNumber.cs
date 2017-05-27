using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int digits01 = int.Parse(Console.ReadLine());
            int digits02 = int.Parse(Console.ReadLine());
            int digits03 = int.Parse(Console.ReadLine());
            int digits04 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{digits01:D4} {digits02:D4} {digits03:D4} {digits04:D4}");


        }
    }
}
