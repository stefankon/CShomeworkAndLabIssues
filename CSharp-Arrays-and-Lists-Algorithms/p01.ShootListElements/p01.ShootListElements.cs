using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.Shootnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string input = Console.ReadLine();

            int shot = 0;

            while (true)
            {

                if (input == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was " + shot);
                        break;
                    }
                    double average = numbers.Average();
                    for (int cnt2 = 0; cnt2 < numbers.Count; cnt2++)
                    {
                        if (numbers[cnt2] < average)
                        {
                            shot = numbers[cnt2];
                            numbers.RemoveAt(cnt2);
                            Console.WriteLine("shot " + shot);
                            break;
                        }
                        else if (numbers.Count == 1)
                        {
                            shot = numbers[0];
                            numbers.RemoveAt(0);
                            Console.WriteLine("shot " + shot);
                            break;
                        }
                    }
                    DecrementEverything(numbers);
                }
                else if (input == "stop")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"you shot them all. last one was {shot}");
                    }
                    else
                    {
                        Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                    }
                    break;
                }
                else
                {
                    Addlements(numbers, input);
                }

                input = Console.ReadLine();
            }
        }

        private static void DecrementEverything(List<int> numbers)
        {
            for (int cnt3 = 0; cnt3 < numbers.Count; cnt3++)
            {
                numbers[cnt3]--;
            }
        }

        private static void Addlements(List<int> numbers, string input)
        {
            int currentElement = int.Parse(input);
            numbers.Insert(0, currentElement);
        }
    }
}
