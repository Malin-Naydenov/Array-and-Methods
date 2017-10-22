using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(GetIntegerToBase(num, toBase));
        }

        private static string GetIntegerToBase(long num, int toBase)
        {
            string result = String.Empty;
            while(num>0)
            {
                long remainder = num % toBase;
                result = remainder + result;
                num /= toBase;

            }
            return result;
        }
    }
}
