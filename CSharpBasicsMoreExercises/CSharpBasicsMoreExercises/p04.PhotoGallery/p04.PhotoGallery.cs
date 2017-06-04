using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {

            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            decimal sizeBytes = int.Parse(Console.ReadLine());
            int widthPixels = int.Parse(Console.ReadLine());
            int heightPixels = int.Parse(Console.ReadLine());
            string bytes = String.Empty;
            string orientation = String.Empty;
        
            if (sizeBytes < 1000)
            {
                sizeBytes = (int)sizeBytes;
                bytes = "B";
            }
            else if ((1000 <= sizeBytes) && (sizeBytes < 1000000))
            {
                sizeBytes = (int)sizeBytes / 1000;
                bytes = "KB";
            }
            else
            {

                sizeBytes = Math.Round((sizeBytes / 1000000), 1);
                bytes = "MB";
            }

            if (widthPixels < heightPixels)
            {
                orientation = "portrait";
            }
            else if (widthPixels > heightPixels)
            {
                orientation = "landscape";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {sizeBytes}{bytes}");
            Console.WriteLine($"Resolution: {widthPixels}x{heightPixels} ({orientation})");
        }
    }
}
