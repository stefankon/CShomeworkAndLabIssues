using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.RegisterUsers
{
    class RegisterUsers
    {
        static void Main(string[] args)
        {

            string inputLine = Console.ReadLine();
            Dictionary<string, List<int>> usernameDate = new Dictionary<string, List<int>>();

            while (inputLine != "end")
            {
                string[] tokens = inputLine
                                        .Split(new string[] { " -> ", "/" }, StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                for (int i = 1; i < tokens.Length; i++)
                {
                    if (!usernameDate.ContainsKey(username))
                    {
                        usernameDate[username] = new List<int>();
                    }
                    usernameDate[username].Add(int.Parse(tokens[i]));

                }
                inputLine = Console.ReadLine();
            }

            usernameDate = usernameDate.Reverse()
                           .OrderBy(x => x.Value[2])
                           .ThenBy(x => x.Value[1])
                           .ThenBy(x => x.Value[0])
                           .ToDictionary(x => x.Key, x => x.Value);


            Dictionary<string, List<int>> output = new Dictionary<string, List<int>>();

            output = usernameDate.Take(5)        
                .ToDictionary(x => x.Key, x => x.Value);

            output = output.OrderByDescending(x => x.Value[2])
                            .ThenByDescending(x => x.Value[1])
                            .ThenByDescending(x => x.Value[0])
                            .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in output)
            {
                Console.WriteLine(kvp.Key);
            }

        }
    }
}
