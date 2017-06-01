using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nigthsCount = int.Parse(Console.ReadLine());

            var studioPrice = 0.0;
            var doublePrice = 0.0;                
            var suitePrice = 0.0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50.0;
                doublePrice = 65.0;
                suitePrice = 75.0;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60.0;
                doublePrice = 72.0;
                suitePrice = 82.0;
            }
            else
            {
                studioPrice = 68.0;
                doublePrice = 77.0;
                suitePrice = 89.0;
            }


            studioPrice = studioPrice * nigthsCount;
            doublePrice = doublePrice * nigthsCount;
            suitePrice = suitePrice * nigthsCount;

            if ((nigthsCount > 7) && (month == "May" || month == "October"))
            {
                studioPrice = studioPrice * 0.95;
                if ((month == "October"))
                {
                    studioPrice = studioPrice - (studioPrice / nigthsCount);
                }
            }
            else if ((nigthsCount > 14) && (month == "June" || month == "September"))
            {
                doublePrice = doublePrice * 0.90;
            }
            else if ((nigthsCount > 14) && (month == "July" || month == "August" || month == "December"))
            {
                suitePrice = suitePrice * 0.85;
            }
            else if ((nigthsCount > 7) && (month == "September" || month == "October"))
            {
                studioPrice = studioPrice - (studioPrice / nigthsCount);
            }

            

            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
            Console.WriteLine($"Double: {doublePrice:F2} lv.");
            Console.WriteLine($"Suite: {suitePrice:F2} lv.");

        }
    }
}
