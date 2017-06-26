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
<<<<<<< HEAD
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
=======
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
           
>>>>>>> 6146da216cc14913ba18fc89db7dae39bdeb7307
            Console.WriteLine(String.Join("\n", playList));
        }
    }
}
<<<<<<< HEAD

=======
>>>>>>> 6146da216cc14913ba18fc89db7dae39bdeb7307
