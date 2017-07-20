using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p00.Test
{
    class Test
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

           
            Console.WriteLine(string.Join(", ", nums.OrderByDescending(x => x)));
                                          
        }
    }
}
