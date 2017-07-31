using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.Messages
{
    class Conversation
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var users = new Dictionary<string, User>();

            string sender;
            string recipient;

            while (input != "exit")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "register")
                {
                    string username = tokens[1];
                    users.Add(username, new User(username));
                }
                else
                {
                    sender = tokens[0];
                    recipient = tokens[2];
                    string content = tokens[3];

                    if (users.ContainsKey(sender) &&
                        users.ContainsKey(recipient))
                    {
                        User senderUser = users[sender];
                        users[recipient].Messages.Add(new Message(content, senderUser));
                    }
                }

                input = Console.ReadLine();
            }
            string[] chatTokens = Console.ReadLine().Split(' ');
            sender = chatTokens[0];
            recipient = chatTokens[1];

            Message[] senderMessages = users[recipient].Messages
                                .Where(m => m.Sender.Username == sender)
                                .ToArray();

            Message[] recipientMessages = users[sender].Messages
                                .Where(m => m.Sender.Username == recipient)
                                .ToArray();
            if (senderMessages.Length == 0 && recipientMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }

            int index = 0;

            while (index < senderMessages.Length && 
                   index < recipientMessages.Length)
            {
                Console.WriteLine("{0}: {1}", sender, senderMessages[index].Content);
                Console.WriteLine("{0} :{1}", recipientMessages[index].Content, recipient);
                index++;
            }
            while (index < senderMessages.Length)
            {
                Console.WriteLine("{0}: {1}", sender, senderMessages[index].Content);
                index++;
            }
            while (index < recipientMessages.Length)
            {
                Console.WriteLine("{0} :{1}", recipientMessages[index].Content, recipient);
                index++;
            }
        }
    }

    class User
    {
        public string Username { get; set; }
        public List<Message> Messages { get; set; }

        public User(string username)
        {
            this.Username = username;
            this.Messages = new List<Message>();
        }
    }
    
    class Message
    {
       public string Content { get; set; }
       public User Sender { get; set; }
        public Message(string content, User sender)
        {
            this.Content = content;
            this.Sender = sender;
        }
    }
}
