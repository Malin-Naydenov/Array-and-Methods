using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string greeting = GetName(name);
            Console.WriteLine(greeting);
        }

         static string GetName(string name)
        {
            return($"Hello, {name}!");
        }
    }
}
