using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05.StringCommander
{
    class StringCommander
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder modifiedText = new StringBuilder();
            modifiedText.Append(input);

            while (input != "end")
            {

                string[] tokens = input.Split(' ');
                string command = tokens[0];


                if (command == "Left")
                {
                    int numL = int.Parse(tokens[1]);
                    for (int i = 0; i < numL; i++)
                    {
                        char @charL = modifiedText[0];
                        modifiedText.Remove(0, 1);
                        modifiedText.Append(@charL);
                    }
                }
                else if (command == "Right")
                {
                    int numR = int.Parse(tokens[1]);
                    for (int i = 0; i < numR; i++)
                    {
                        int endPosition = modifiedText.Length - 1;
                        char @charR = modifiedText[endPosition]; ;
                        modifiedText.Remove((modifiedText.Length - 1), 1);
                        modifiedText.Insert(0, @charR);
                    }
                }
                else if (command == "Insert")
                {
                    int positionIn = int.Parse(tokens[1]);
                    string strIn = tokens[2];
                    modifiedText.Insert(positionIn, strIn);
                }
                else if (command == "Delete")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    string temp = modifiedText.ToString();
                    string str1 = temp.Substring(0, startIndex);
                    string str2 = temp.Substring(endIndex + 1, temp.Length - endIndex - 1);
                    
                    modifiedText = new StringBuilder(str1 + str2);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(modifiedText);
        }
    }
}
