using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.Boxes
{
    class Boxes
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<BoxPoints> data = new List<BoxPoints>();

            while (input != "end")
            {
                string[] tokens = input
                                  .Split(new string[] { " | " },
                                        StringSplitOptions.RemoveEmptyEntries)
                                               .ToArray();
                Coordinates point1 = Coordinates.ParsePoint(tokens[0]);
                Coordinates point2 = Coordinates.ParsePoint(tokens[1]);
                Coordinates point3 = Coordinates.ParsePoint(tokens[2]);
                Coordinates point4 = Coordinates.ParsePoint(tokens[3]);

                int upperleftX = point1.X;
                int upperleftY = point1.Y;
                int upperRightX = point2.X;
                int upperRightY = point2.Y;
                int bottomleftX = point3.X;
                int bottomleftY = point3.Y;
                int bottomRightX = point4.X;
                int bottomRightY = point4.Y;

                BoxPoints currentBox = new BoxPoints(upperleftX, upperleftY, upperRightX, upperRightY,
                                                    bottomleftX, bottomleftY, bottomRightX, bottomRightY);

                data.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in data)
            {
                int width = (int)Math.Sqrt(Math.Pow((box.UpperleftX - box.UpperRightX), 2)
                                            + Math.Pow((box.UpperleftY - box.UpperRightY), 2));
                int height = (int)Math.Sqrt(Math.Pow((box.UpperleftX - box.BottomleftX), 2)
                                            + Math.Pow((box.UpperleftY - box.BottomleftY), 2));

                int perimeter = (2 * width) + (2 * height);
                int area = width * height;

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");

            }
        }
    }

    class BoxPoints
    {
        public int UpperleftX { get; set; }
        public int UpperleftY { get; set; }
        public int UpperRightX { get; set; }
        public int UpperRightY { get; set; }
        public int BottomleftX { get; set; }
        public int BottomleftY { get; set; }
        public int BottomRightX { get; set; }
        public int BottomRightY { get; set; }

        public BoxPoints(int ulX, int ulY, int urX, int urY,
                         int blX, int blY, int brX, int brY)
        {
            this.UpperleftX = ulX;
            this.UpperleftY = ulY;
            this.UpperRightX = urX;
            this.UpperRightY = urY;
            this.BottomleftX = blX;
            this.BottomleftY = blY;
            this.BottomRightX = brX;
            this.BottomRightY = brY;
        }
    }

    class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int xCoord, int yCoord)
        {
            this.X = xCoord;
            this.Y = yCoord;
        }
        public static Coordinates ParsePoint(string input)
        {
            int[] inputData = input.Split(':').Select(int.Parse).ToArray();
            return new Coordinates(inputData[0], inputData[1]);
        }
    }
}