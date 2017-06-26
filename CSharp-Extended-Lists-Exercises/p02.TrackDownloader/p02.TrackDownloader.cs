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
            List<string> checkList = Console.ReadLine().Split(' ').ToList();
            string currentInput = Console.ReadLine();
            
            List<string> playList = new List<string>();

            while (currentInput != "end")
            {
                bool exceptions = false;
                for (int cnt = 0; cnt < checkList.Count; cnt++)
                {
                    if (currentInput.Contains(checkList[cnt]))
                    {
                        exceptions = true;
                    }
                }

                if (!exceptions)
                {
                    playList.Add(currentInput);
                      }
                currentInput = Console.ReadLine();

            }
            playList.Sort();
            Console.WriteLine(String.Join("\n", playList));
        }
    }
}

