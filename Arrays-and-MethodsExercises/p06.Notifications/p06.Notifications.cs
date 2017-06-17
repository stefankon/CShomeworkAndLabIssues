using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());

            for (int cnt = 0; cnt < linesNumber; cnt++)
            {
                string check = Console.ReadLine();

                if (check == "success")
                {
                    string opeartion = Console.ReadLine();
                    string message = Console.ReadLine();

                    ShowSuccess(opeartion, message);
                }
                else if (check == "error")
                {
                    string opeartion = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    string reason = String.Empty;
                    ShowError(opeartion, code);
                    if (code < 0)
                    {
                        reason = "Internal System Failure";
                    }
                    else 
                    {
                        reason = "Invalid Client Data";
                    }

                    Console.WriteLine($"Reason: {reason}.");
                }
                else
                {
                    continue;
                }
            }
        }

        static string ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");

            return "";
        }

        static string ShowError(string operation, int code)
        {

            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");


            return "";
        }

    }
}
