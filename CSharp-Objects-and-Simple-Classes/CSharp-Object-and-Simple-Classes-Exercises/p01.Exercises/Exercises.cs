using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01.Exercises
{
    class Exercises
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }

        public Exercises(string topic, string coursName, string judgeContestLink, List<string> problems)
        {
            this.Topic = topic;
            this.CourseName = coursName;
            this.JudgeContestLink = judgeContestLink;
            this.Problems = problems;
        }
    }
    class DataInput
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<Exercises> mainList = new List<Exercises>();

            while (input != "go go go")
            {
                string[] tokens = input
                                  .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();

                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeContestLink = tokens[2];
                List<string> problems = tokens[3]
                                        .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();

                mainList.Add(new Exercises(topic, courseName, judgeContestLink, problems));

                input = Console.ReadLine();
                
            }
            foreach (var ex in mainList)
            {
                string currTopic = ex.Topic;
                string currCourseName = ex.CourseName;
                string currJudgeContestLink = ex.JudgeContestLink;
                List<string> currProblems = ex.Problems;
                Console.Write($"Exercises: ");
                Console.WriteLine(currTopic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni.", currCourseName);
                Console.WriteLine("Check your solutions here: {0}", currJudgeContestLink);

                int counter = 1;
                foreach (var ex2 in currProblems)
                {
                    Console.WriteLine($"{counter}. " + ex2);
                    counter++;
                }
                
            }
        }
    }
}

