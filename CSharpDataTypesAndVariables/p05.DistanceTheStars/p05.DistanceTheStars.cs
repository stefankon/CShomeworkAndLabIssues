using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.DistanceTheStars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal nearestStar = 4.22m;
            decimal galaxyCenter = 26000m;
            decimal diameterMilkyWay = 100000m;
            decimal observableUniverse = 46500000000m;
            decimal lightYearKm = 9450000000000m;

            Console.WriteLine((nearestStar * lightYearKm).ToString("e2", CultureInfo.InvariantCulture));
            Console.WriteLine((galaxyCenter * lightYearKm).ToString("e2", CultureInfo.InvariantCulture));
            Console.WriteLine((diameterMilkyWay * lightYearKm).ToString("e2", CultureInfo.InvariantCulture));
            Console.WriteLine((observableUniverse * lightYearKm).ToString("e2", CultureInfo.InvariantCulture));
        }
    }
}
