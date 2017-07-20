using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var tagsData = new Dictionary<string, HashSet<string>>();

            while (inputLine != "filter")
            {
                string[] tokens = ParseTopic(inputLine);
                string topic = tokens[0];
                string[] tags = ParseTags(tokens[1]);

                DataStore(tagsData, topic, tags);
                
                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();

            var tagsForCheck = ParseTags(inputLine);

            foreach (var kvp in tagsData)
            {
                var topic = kvp.Key;
                var tags = kvp.Value;
                
                var hashtagedList = tags.Select(ht => "#" + ht);
                if (allTags(tags, tagsForCheck))
                {
                    Console.WriteLine($"{topic} | {string.Join(", ", hashtagedList)}");
                }
            }
        }
        public static string[] ParseTopic(string inputLine)
        {
            return inputLine
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries); ;
        }

        public static string[] ParseTags(string tokens)
        {
            return tokens
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries); ;
        }

        static void DataStore(
                        Dictionary<string, HashSet<string>> tagsData,
                        string topic,
                        string[] tags)
        {
            if (!tagsData.ContainsKey(topic))
            {
                tagsData[topic] = new HashSet<string>();
            }
            for (int i = 0; i < tags.Length; i++)
            {
                tagsData[topic].Add(tags[i]);
            }
        }

        static bool allTags(HashSet<string> tags, string[] tagsForCheck)
        {
            foreach (var tag in tagsForCheck)
            {
                if (!tags.Contains(tag))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
