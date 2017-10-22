using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nLines; i++)
            {
                string code = Console.ReadLine();
                if (code == "success")
                {
                    ShowSuccessCode(code);
                }
                else if (code == "error")
                {
                    ShowErrorCode(code);
                }
                else
                {
                    continue;
                }
            }
        }

        static void ShowErrorCode(string code)
        {
            string text = Console.ReadLine();
            int errorCode = int.Parse(Console.ReadLine());

            Console.WriteLine($"Error: Failed to execute {text}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {errorCode}.");
            if (errorCode >= 0)
            {
                Console.WriteLine("Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine("Reason: Internal System Failure.");
            }
        }

        static void ShowSuccessCode(string code)
        {
            string text = Console.ReadLine();
            string message = Console.ReadLine();
            Console.WriteLine($"Successfully executed {text}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }
    }
}
