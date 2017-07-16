using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, string> positionData = new Dictionary<string, string>();
            Dictionary<string, int> ageData = new Dictionary<string, int>();
            Dictionary<string, double> salaryData = new Dictionary<string, double>();

           

            while (inputLine != "filter base")
            {
                string[] tokens = inputLine.Split(' ').ToArray();
                string name = tokens[0];
                string position = "";
                int age = 0;
                double salary = 0.0;
                

                if (int.TryParse(tokens[2], out age))
                {
                    ageData[name] = age;
                   
                }
                else if (double.TryParse(tokens[2], out salary))
                {
                    salaryData[name] = salary;
                   
                }
                else
                {
                    position = tokens[2];
                    positionData[name] = position;
                }

                inputLine = Console.ReadLine();
            }
            inputLine = Console.ReadLine();
            string mainFilter = inputLine;

            if (mainFilter == "Age")
            {
                foreach (var kvp in ageData)
                {
                    var name = kvp.Key;
                    var age = kvp.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine("====================");
                }

            }
            else if (mainFilter == "Salary")
            {
                foreach (var kvp in salaryData)
                {
                    var name = kvp.Key;
                    var salary = kvp.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Salary: {salary:F2}");
                    Console.WriteLine("====================");
                }
            }
            else // Position
            {
                foreach (var kvp in positionData)
                {
                    var name = kvp.Key;
                    var position = kvp.Value;
                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Position: {position}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
