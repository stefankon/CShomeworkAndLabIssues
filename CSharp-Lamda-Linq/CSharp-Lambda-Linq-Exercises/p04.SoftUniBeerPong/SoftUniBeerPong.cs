using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.SoftUniBeerPong
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, int>> dataTeams = new Dictionary<string, Dictionary<string, int>>();

            while (input != "stop the game")
            {
                BeerTeams inputIlne = BeerTeams.ParseTokens(input);
                if (!dataTeams.ContainsKey(inputIlne.Team))
                {
                    dataTeams.Add(inputIlne.Team, new Dictionary<string, int>());
                }

                if (dataTeams[inputIlne.Team].Count < 3)
                {
                    dataTeams[inputIlne.Team].Add(inputIlne.Player, inputIlne.PointsMade);
                }

                input = Console.ReadLine();
            }

            var listInOrder = dataTeams
                              .Where(x => x.Value.Count == 3)
                              .OrderByDescending(x => x.Value.Sum(score => score.Value));

            int numOrder = 1;

            foreach (var kvp1 in listInOrder)
            {
                Dictionary<string, int> playersRancing = kvp1.Value;
                var playersOrdred = playersRancing.OrderByDescending(x => x.Value);

                Console.WriteLine($"{numOrder}. {kvp1.Key}; Players:");
                foreach (var kvp2 in playersOrdred)
                {
                    Console.WriteLine($"###{kvp2.Key}: {kvp2.Value}");
                }
                numOrder++;

            }

        }
    }
    class BeerTeams
    {
        //private int points;

        public BeerTeams(string player, string team, int points)
        {
            Player = player;
            Team = team;
            PointsMade = points;
        }

        public string Team { get; set; }
        public string Player { get; set; }
        public int PointsMade { get; set; }

        public static BeerTeams ParseTokens(string input)
        {
            string[] tokens = input
                            .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            var player = tokens[0];
            var team = tokens[1];
            var points = int.Parse(tokens[2]);

            return new BeerTeams(player, team, points);

        }
    }
}