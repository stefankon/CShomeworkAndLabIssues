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
            int temp = 0;

            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    startPosition = i;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] individualPlayer = players[i].Split(',').ToArray();
                playerTurns = int.Parse(individualPlayer[0]);
                string direction = individualPlayer[1];

                switch (direction)
                {
                    case "Right":
                        startPosition = ((startPosition + playerTurns) % cylinder.Length);
                        temp = startPosition;
                        break;
                    case "Left":
                        if (startPosition - playerTurns < 0)
                        {
                            startPosition = cylinder.Length - (Math.Abs((startPosition - playerTurns) % cylinder.Length));
                        }
                        else
                        {
                            startPosition = startPosition - playerTurns;
                        }
                        
                        break;
                }
                if (startPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isPlayrDead = true;
                    break;
                }

                startPosition = startPosition + 1 == cylinder.Length ? 0 : startPosition + 1;
            }
            if (!isPlayrDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
