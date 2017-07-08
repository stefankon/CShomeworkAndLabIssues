using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            int lineNum = int.Parse(Console.ReadLine());
            HashSet<string> inputName = new HashSet<string>();

            for (int i = 0; i < lineNum; i++)
            {
                inputName.Add(Console.ReadLine());
            }
            //Console.WriteLine("------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, inputName));
        }
    }
}
