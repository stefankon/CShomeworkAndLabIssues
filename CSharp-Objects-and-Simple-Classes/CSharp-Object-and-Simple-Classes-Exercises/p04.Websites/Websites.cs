using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04.Websites
{
    class Websites
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<WebsitesData> websites = new List<WebsitesData>();

            while (input != "end")
            {
                string[] tokens = input
                                  .Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries)
                                  .ToArray();

                if (tokens.Length > 2)
                {
                    string host = tokens[0];
                    string domain = tokens[1];
                    List<string> queries = tokens[2].Split(',').ToList();
                    websites.Add(new WebsitesData(host, domain, queries));
                }
                else
                {
                    string host = tokens[0];
                    string domain = tokens[1];
                    List<string> queries = new List<string>();
                    websites.Add(new WebsitesData(host, domain, queries));
                }
                input = Console.ReadLine();
            }
            bool isQueries = false;
            foreach (var web in websites)
            {
                string currHost = web.Host;
                string currDomain = web.Domain;
                List<string> currQueries = web.Queris;
                int endQueries = currQueries.Count;
                if (endQueries > 0)
                {
                    isQueries = true;
                }
                else
                {
                    isQueries = false;
                }

                if (!isQueries)
                {
                    Console.WriteLine($"https://www.{currHost}.{currDomain}");
                }
                else if (isQueries)
                {
                    Console.Write($"https://www.{currHost}.{currDomain}/query?=");

                    for (int i = 0; i < currQueries.Count; i++)
                    {
                        if (i < endQueries && i != (endQueries - 1))
                        {
                            Console.Write($"[{currQueries[i]}]&");
                        }
                        if (i == (endQueries - 1))
                        {
                            Console.Write($"[{currQueries[i]}]");
                            break;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    class WebsitesData
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queris { get; set; }

        public WebsitesData(string host, string domain, List<string> queries)
        {
            this.Host = host;
            this.Domain = domain;
            this.Queris = queries;
        }
    }
}
