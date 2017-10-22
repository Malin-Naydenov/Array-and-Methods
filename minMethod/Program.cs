using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            GetMin(a, b);
            int minNum = Math.Min(c, GetMin(a, b));
            Console.WriteLine(minNum);
        }

        private static int GetMin(int a, int b)
        {
            return Math.Min(a, b);
        }
    }
}
