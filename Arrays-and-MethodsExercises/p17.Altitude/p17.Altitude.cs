using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();


            long result = long.Parse(input[0]);
            for (int cnt = 1; cnt < input.Length; cnt++)
            {
                if (result > 0)
                {
                    if (cnt % 2 != 0)
                    {
                        long currentAltitude = long.Parse(input[cnt + 1]);
                        if (input[cnt] == "up")
                        {
                            result += currentAltitude;
                        }
                        else if (input[cnt] == "down")
                        {
                            result -= currentAltitude;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (result > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {result}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
