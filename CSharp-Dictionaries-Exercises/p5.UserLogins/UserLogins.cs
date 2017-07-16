using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p5.UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, string> usersLogin = new Dictionary<string, string>();
            int loginCounter = 0;

            while (inputLine != "login")
            {
                string[] tokens = inputLine.Split(' ');
                string user = tokens[0];
                string password = tokens[2];

                if (!usersLogin.ContainsKey(user))
                {
                    usersLogin[user] = "";
                }
                usersLogin[user] = password;

                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(' ');
                string user = tokens[0];
                string password = tokens[2];

                if (!usersLogin.ContainsKey(user))
                {
                    usersLogin[user] = "rejection";
                }

                if (usersLogin[user] == password)
                {
                    Console.WriteLine($"{user}: logged in successfully");
                }
                else if (usersLogin[user] != password || usersLogin[user] == "rejection")
                {
                    Console.WriteLine($"{user}: login failed");
                    loginCounter++;
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {loginCounter}");
        }
    }
}
