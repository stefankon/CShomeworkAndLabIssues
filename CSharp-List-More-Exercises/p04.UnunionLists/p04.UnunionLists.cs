using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();
            int number = int.Parse(Console.ReadLine());


            for (int cnt = 0; cnt < number; cnt++)
            {
                List<int> currentList = Console.ReadLine()
                                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToList();

                primalList = primalList.Distinct().ToList();
                currentList = currentList.Distinct().ToList();

                for (int i = 0; i < currentList.Count; i++)
                {
                    if (primalList.Contains(currentList[i]))
                    {
                        primalList.Remove(currentList[i]);
                        currentList.Remove(currentList[i]);
                        i--;
                    }
                    
                }
                for (int j = 0; j < currentList.Count; j++)
                {
                    primalList.Add(currentList[j]);
                }

            }

            primalList.Sort();
            Console.WriteLine(String.Join(" ", primalList));
        }
    }
}
