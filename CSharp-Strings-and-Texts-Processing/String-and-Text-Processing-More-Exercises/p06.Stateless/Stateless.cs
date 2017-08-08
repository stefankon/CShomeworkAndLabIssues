using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace p06.Stateless
{
    class Stateless
    {
        static void Main(string[] args)
        {
            string state;
            string fiction;

            while (true)
            {
                state = Console.ReadLine();
                if (state == "collapse")
                {
                    return;
                }
                fiction = Console.ReadLine();
                state = Collapsing(state, fiction);
                
                if (state != "")
                {
                    Console.WriteLine(state.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }
            }
        }

        private static string Collapsing(string state, string fiction)
        {
            string pattern = fiction;
            string replacement = "";

            int index = - 1;
            while ((index = pattern.Length - 1) > -1)
            {
                Regex rgx = new Regex(pattern);
                state = rgx.Replace(state, replacement);
                if (index > 0)
                {
                    pattern = pattern.Substring(1, pattern.Length - 1 - 1);
                }
                else
                {
                    break;
                }
            }
            return state;
        }
    }
}
