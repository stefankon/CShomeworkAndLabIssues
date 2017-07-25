using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.Boxes
{
    class Boxes
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] input = inputLine
                    .Split(new string[] { " | " },
                            StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

                Point upperLeft = Point.ParsePoint(input[0]);
                Point upperRight = Point.ParsePoint(input[1]);
                Point bottomLeft = Point.ParsePoint(input[2]);
                Point bottomRight = Point.ParsePoint(input[3]);

                inputLine = Console.ReadLine();
            }
        }

        private static Point ReadPoint(string input)
        {
            int[] inputData = input.Split(':').Select(int.Parse).ToArray();
            return new Point(inputData[0], inputData[1]);
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xCoord, int yCoord)
        {
            this.X = xCoord;
            this.Y = yCoord;
        }
        public static Point ParsePoint(string input)
        {
            int[] inputData = input.Split(':').Select(int.Parse).ToArray();
            return new Point(inputData[0], inputData[1]);
        }
    }
}
