using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p05.PointsCounter
{
    class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                Player other = (Player)obj;

                return this.Name == other.Name;
            }

            return false;
        }
    }


    class PointsCounter 
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var data = new Dictionary<string, List<Player>>();

            while (input != "Result")
            {
                string[] tokens = input.Split('|');

                string teamName;
                string playerName;
                int points = int.Parse(tokens[2]);

                if (IsTeamName(tokens[0]))
                {
                    teamName = tokens[0];
                    playerName = tokens[1];
                }
                else
                {
                    teamName = tokens[1];
                    playerName = tokens[0];
                }

                teamName = Unpolluted(teamName);
                playerName = Unpolluted(playerName);

                if (!data.ContainsKey(teamName))
                {
                    data.Add(teamName, new List<Player>());
                }

                Player currentPlayer = new Player(playerName, points);
                if (!data[teamName].Contains(currentPlayer))
                {
                    data[teamName].Add(currentPlayer);
                }
                else
                {
                    int index = data[teamName].IndexOf(currentPlayer);
                    data[teamName][index] = currentPlayer;
                }
                input = Console.ReadLine();
            }

            var orderedData = data
                              .OrderByDescending(teamData => teamData.Value.Sum(p => p.Points));

            foreach (var teamData in orderedData)
            {
                string teamName = teamData.Key;
                List<Player> players = teamData.Value;
                int totalPoints = players.Sum(p => p.Points);
                Player bestPlayer = players.OrderByDescending(p => p.Points).First();

                Console.WriteLine($"{teamName} => {totalPoints}");
                Console.WriteLine($"Most points scored by {bestPlayer.Name}");
            }
        }

        static string Unpolluted(string name)
        {
            StringBuilder result = new StringBuilder();

            foreach (char symbol in name)
            {
                if (!IsPollutedChar(symbol))
                {
                    result.Append(symbol);
                }
            }

            return result.ToString();
        }

        static bool IsPollutedChar(char symbol)
        {
            return symbol == '@' ||
                   symbol == '%' ||
                   symbol == '$' ||
                   symbol == '*';
        }

        static bool IsTeamName(string name)
        {
            // return !name.Any(ch => char.IsLower(ch));
            for (int ch = 0; ch < name.Length; ch++)
            {
                if (char.IsLower(name[ch]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
