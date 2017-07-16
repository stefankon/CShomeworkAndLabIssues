using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            SortedDictionary<string, long> phoneBook = new SortedDictionary<string, long>();

            while (inputLine != "Over")
            {

                string[] tokens = inputLine
                                  .Split(new char[] {' ',':'}, StringSplitOptions
                                  .RemoveEmptyEntries);


                long number = 0;
                bool isNumberFirst = long.TryParse(tokens[0], out number);
                
                if (isNumberFirst)
                {
                    phoneBook[tokens[1]] = number;
                }
                if (!isNumberFirst)
                {
                    phoneBook[tokens[0]] = long.Parse(tokens[1]);
                }
                
                inputLine = Console.ReadLine();

            }
            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
