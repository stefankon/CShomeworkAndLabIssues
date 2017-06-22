using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02.TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentInput = Console.ReadLine();
            string exception1 = "Metallica";
            string exception2 = "Linkin Park";

            List<string> playList = new List<string>();
            List<string> checkList = new List<string>();
            if (currentInput == "end")
            {
                Console.WriteLine();
            }
            else
            {
                while (currentInput != "end")
                {
                    bool exceptions = checkList.Contains(exception1) || currentInput.Contains(exception2);

                    checkList = currentInput.Split(' ').ToList();

                    for (int cnt = 0; cnt < checkList.Count; cnt++)
                    {
                        if (!exceptions && currentInput != "end")
                        {
                            playList.Add(currentInput);
                        }
                        currentInput = Console.ReadLine();
                    }

                }
            }
           
            Console.WriteLine(String.Join("\n", playList));
        }
    }
}
