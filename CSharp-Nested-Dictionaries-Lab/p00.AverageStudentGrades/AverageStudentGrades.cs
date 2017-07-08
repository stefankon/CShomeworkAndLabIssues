using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p00.AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            int counterNum = int.Parse(Console.ReadLine());
            var averageGrades = new Dictionary<string, List<double>>();
           
            for (int cnt = 0; cnt < counterNum; cnt++)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                string name = tokens[0];
                double currentGrade = double.Parse(tokens[1]);

                
                    if (!averageGrades.ContainsKey(name))
                    {
                        averageGrades[name] = new List<double>();
                    }
                    averageGrades[name].Add(currentGrade);
                
            }
            foreach (KeyValuePair<string, List<double>> kvp in averageGrades)
            {
                string nameToPrint = kvp.Key;
                List<double> listToPrint = kvp.Value;
                double average = listToPrint.Average();
                
                Console.Write($"{nameToPrint} -> ");
                foreach (var grade in listToPrint)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
                
            }
        }
    }
}
