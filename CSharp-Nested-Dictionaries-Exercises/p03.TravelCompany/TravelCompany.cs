using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> travelData
                                = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> output = new Dictionary<string, int>();
            List<string> cityOutput = new List<string>();
            Dictionary<string, Dictionary<int, int>> printList
                                = new Dictionary<string, Dictionary<int, int>>();


            while (inputLine != "ready")
            {
                string[] tokens = inputLine
                        .Split(new string[] { ":", ",", "-" }, StringSplitOptions.RemoveEmptyEntries);
                string city = tokens[0];

                if (!travelData.ContainsKey(city))
                {
                    travelData[city] = new Dictionary<string, int>();
                }

                Dictionary<string, int> transportList = new Dictionary<string, int>();
                for (int i = 1; i < tokens.Length; i += 2)
                {
                    var currentTransport = tokens[i];
                    var currentCapacity = int.Parse(tokens[i + 1]);
                    if (!travelData[city].ContainsKey(currentTransport))
                    {
                        travelData[city][currentTransport] = 0;
                    }
                    travelData[city][currentTransport] = currentCapacity;
                }
                if (!output.ContainsKey(city))
                {
                    output[city] = 0;
                    cityOutput.Add(city);
                }
                inputLine = Console.ReadLine();
            }


            for (int i = 0; i < cityOutput.Count; i++)
            {
                foreach (var kvp in travelData)
                {
                    var cityAdd = kvp.Key;

                    var sum = kvp.Value;
                    foreach (var kvp2 in sum)
                    {
                        int sumToAdd = kvp2.Value;
                        if (cityOutput[i] == cityAdd)
                        {
                            output[cityOutput[i]] += sumToAdd;
                        }
                    }
                }
            }
            inputLine = Console.ReadLine();
            while (inputLine != "travel time!")
            {
                string[] tokens2 = inputLine.Split();
                var cityOffer = tokens2[0];
                var peopleCount = int.Parse(tokens2[1]);
                output[cityOffer] -= peopleCount;
                if (!printList.ContainsKey(cityOffer))
                {
                    printList[cityOffer] = new Dictionary<int, int>();
                }
                if (!printList[cityOffer].ContainsKey(peopleCount))
                {
                    printList[cityOffer][peopleCount] = 0;
                }
                printList[cityOffer][peopleCount] = output[cityOffer];
                inputLine = Console.ReadLine();
            }
            foreach (var kvp in printList)
            {
                var cityPrint = kvp.Key;
                var peoplePrint = kvp.Value;
                
                Console.Write($"{cityPrint} -> ");
                foreach (var kvp2 in peoplePrint)
                {
                    var peopleOffer = kvp2.Key;
                    var peopleCapacity = kvp2.Value;
                    if (peopleCapacity > 0)
                    {
                        Console.WriteLine($"all {peopleOffer} accommodated");
                    }
                    else if (peopleCapacity <= 0)
                    {
                        Console.WriteLine($"all except {Math.Abs(peopleCapacity)} accommodated");
                    }
                }
            }
        }
    }
}
