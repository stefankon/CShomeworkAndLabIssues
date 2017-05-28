using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());
            var ticketPrice = 0;

            if (0 <= age && age <= 18)
            {
                switch (day)
                {
                    case "weekday":
                        ticketPrice = 12;
                        break;
                    case "weekend":
                        ticketPrice = 15;
                        break;
                    case "holiday":
                        ticketPrice = 5;
                        break;

                    default:
                        break;
                }
            }
            else if (18 < age && age <= 64)
            {
                switch (day)
                {
                    case "weekday":
                        ticketPrice = 18;
                        break;
                    case "weekend":
                        ticketPrice = 20;
                        break;
                    case "holiday":
                        ticketPrice = 12;
                        break;

                    default:
                        break;
                }
            }
            else if (64 < age && age <= 122)
            {
                switch (day)
                {
                    case "weekday":
                        ticketPrice = 12;
                        break;
                    case "weekend":
                        ticketPrice = 15;
                        break;
                    case "holiday":
                        ticketPrice = 10;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                ticketPrice = 0;
            }

            if (ticketPrice != 0)
            {
                Console.WriteLine($"{ticketPrice}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }

    }
}
