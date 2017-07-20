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
            List<BeerTeams> dataCompetition = new List<BeerTeams>();
            Dictionary<string, int> teamCount = new Dictionary<string, int>();

            while (input != "stop the game")
            {
                BeerTeams inputIlne = BeerTeams.ParseTokens(input);
                if (true)
                {

                }
                dataCompetition.Add(inputIlne);

                input = Console.ReadLine();
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
