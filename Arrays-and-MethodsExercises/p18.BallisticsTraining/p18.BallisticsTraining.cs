using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p18.BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinatesInput = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

            string[] commands = Console.ReadLine().Split(' ').ToArray();

            int coordinateX = 0;
            int coordinateY = 0;

            for (int cnt = 0; cnt < commands.Length; cnt++)
            {
                
                if (cnt % 2 == 0)
                {
                    switch (commands[cnt])
                    {
                        case "right":
                            coordinateX += int.Parse(commands[cnt + 1]);
                            break;
                        case "left":
                            coordinateX -= int.Parse(commands[cnt + 1]);
                            break;
                        case "up":
                            coordinateY += int.Parse(commands[cnt + 1]);
                            break;
                        case "down":
                            coordinateY -= int.Parse(commands[cnt + 1]);
                            break;
                        default:
                            break;
                    }
                   
                }
            }
            if ((coordinatesInput[0] == coordinateX) && (coordinatesInput[1] == coordinateY))
            {
                Console.WriteLine($"firing at [{coordinateX}, {coordinateY}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{coordinateX}, {coordinateY}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
