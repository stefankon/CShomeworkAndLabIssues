using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07.CapitalizeWodrs
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            char[] delimiter = {',', '.', '/', '<', '>', '?',
                                ';', ':', '"', '=', '|', '+',
                                '-', '*', '_', '(', ')', '&',
                                '^', '%', '{', '}', '[', '}',
                                ' ', '!', '@', '#', '$', '\\'};

            List<string> textToPrint = new List<string>();

            while (input != "end")
            {
                string[] words = input
                                    .Split(delimiter, 
                                        StringSplitOptions.RemoveEmptyEntries)
                                            .ToArray();

                StringBuilder currentText = new StringBuilder();

                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToLower();
                    words[i] = FirstLetterToUpper(words[i]);
                }

                Console.WriteLine(string.Join(", ", words));

                input = Console.ReadLine();
            }

        }

        public static string FirstLetterToUpper(string str)
        {
            if (string.IsNullOrEmpty(str))
                return string.Empty;
            // convert to char array of the string
            char[] letters = str.ToCharArray();
            // upper case the first char
            letters[0] = char.ToUpper(letters[0]);
            // return the array made of the new char array
            return new string(letters);
        }
    }
}
