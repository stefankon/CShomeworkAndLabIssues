using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int lineCounter = int.Parse(Console.ReadLine());
            var wardorbe = new Dictionary<string, Dictionary<string, int>>();
            
            for (int cnt1 = 0; cnt1 < lineCounter; cnt1++)
            {
                string[] tokens = Console.ReadLine()
                              .Split(new string[] { " -> ", "," }, StringSplitOptions
                              .RemoveEmptyEntries)
                              .ToArray();

                string color = tokens[0];
                string curentDress = "";


                if (!wardorbe.ContainsKey(color))
                {
                    wardorbe.Add(color, new Dictionary<string, int>());
                }


                for (int cnt2 = 1; cnt2 < tokens.Length; cnt2++)
                {
                    curentDress = tokens[cnt2];
                    if (!wardorbe[color].ContainsKey((curentDress)))
                    {
                        wardorbe[color].Add(curentDress, 0);
                    }
                    wardorbe[color][curentDress]++;
                }
            }
            string[] checkColor = Console.ReadLine().Split(' ').ToArray();

            foreach (var color in wardorbe)
            {
                string printColor = color.Key;
                Dictionary<string, int> dressBox = color.Value;
                Console.WriteLine("{0} clothes:", printColor);

                foreach (var print in dressBox)
                {
                    var itemDress = print.Key;
                    var countDress = print.Value;
                    Console.Write($"* {itemDress} - {countDress}");
                    if (printColor == checkColor[0] && itemDress == checkColor[1])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
