using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            hours += (minutes / 60);
            minutes = minutes % 60;

            if (hours >= 24)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);
        }
    }
}
