using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            int realNum = GetIndex(number, index);
            Console.WriteLine(realNum);
        }

         static int GetIndex(int number, int index)
        {
            
            int safeNum = 0;
            int count = 0;
            for (int i = 1; i <= index; i++)
            {
                safeNum = number % 10;
                
                number=number / 10;
                count++;
                

            }
            return safeNum;
        }
    }
}
