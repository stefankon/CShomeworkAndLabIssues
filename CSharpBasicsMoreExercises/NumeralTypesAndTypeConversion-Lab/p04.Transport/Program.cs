using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.Transport
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberPeople = int.Parse(Console.ReadLine());

            int capacity = 4 + 8 + 12;
            int numberCourses = (int)Math.Ceiling((double)numberPeople / capacity);

            Console.WriteLine(numberCourses);
        }
    }
}
