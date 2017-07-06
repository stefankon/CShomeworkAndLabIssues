using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            int[] cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] players = Console.ReadLine().Split(' ').ToArray();

            int startPosition = 0;
            int playerTurns = 0;
            bool isPlayrDead = false;

            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    startPosition = i;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] individualPlayer = players[i].Split(',').ToArray();
                playerTurns = int.Parse(individualPlayer[0]);
                string direction = individualPlayer[1];

                if (direction == "Right")
                {
                   
                }
            }


            Console.WriteLine(startPosition);
            //Console.WriteLine(string.Join("-*-", players));
        }   
    }
}
