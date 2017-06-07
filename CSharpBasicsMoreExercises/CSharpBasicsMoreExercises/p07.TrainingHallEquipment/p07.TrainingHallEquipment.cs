using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            int itemToBuy = int.Parse(Console.ReadLine());

            string itemName = String.Empty;
            double itemPrice = 0.0;
            int itemCount = 0;
            double subtotal = 0.0;



            for (int i = 0; i < itemToBuy; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = double.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());
                if (itemCount > 1 && itemName.EndsWith("y") )
                {
                    itemName = itemName.Remove(itemName.Length - 1);
                    itemName += "ies";
                }
                else if (itemCount > 1 && (itemName.EndsWith("o") || itemName.EndsWith("ch") ||
                                            itemName.EndsWith("s") || itemName.EndsWith("sh") ||
                                            itemName.EndsWith("x") || itemName.EndsWith("z")))
                {
                    itemName += "es";
                }
                else
                {
                    itemName += "s";
                }

                subtotal += itemPrice * itemCount;
                
                Console.WriteLine("Adding {0} {1} to cart.", itemCount, itemName);
                
            }

            Console.WriteLine("Subtotal: ${0:F2}", subtotal);
            double moneyLeft = budget - subtotal;

            if (moneyLeft >= 0)
            {
                Console.WriteLine("Money left: ${0:F2}", moneyLeft);
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:F2} more.", Math.Abs(moneyLeft));
            }

            
        }
    }
}
