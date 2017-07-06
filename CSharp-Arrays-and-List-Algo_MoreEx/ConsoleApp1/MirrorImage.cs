using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03.MirrorImage
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
            List<string> mirrorImage = Console.ReadLine().Split(' ').ToList();
            string command = Console.ReadLine();

            List<string> listToPrint = new List<string>();
            List<string> tempList = new List<string>(mirrorImage);

            while (command != "Print")
            {
                int index;
                //tempList = new List<string>();


                bool indextNum = Int32.TryParse(command, out index);
                if (indextNum)
                {
                    string temp = mirrorImage[index];
                    for (int i = 0; i < index; i++)
                    {
                        listToPrint.Insert(0, tempList[i]);
                    }

                    listToPrint.Add(tempList[index]);

                    for (int i = tempList.Count - 1; i > index; i--)
                    {
                        listToPrint.Add(tempList[i]);
                    }
                    tempList.Clear();
                    tempList = new List<string>(listToPrint);
                    listToPrint.Clear();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", tempList));

        }
    }
}
