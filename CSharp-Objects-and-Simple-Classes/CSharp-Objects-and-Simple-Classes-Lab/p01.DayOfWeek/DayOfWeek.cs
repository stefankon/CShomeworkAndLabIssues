using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();

            DateTime data = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(data.DayOfWeek);
        }
    }
}
