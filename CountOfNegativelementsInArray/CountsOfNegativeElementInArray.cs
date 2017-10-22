using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNegativelementsInArray
{
    class CountsOfNegativeElementInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetCountNegative(n));
        }

         static int GetCountNegative(int n)
        {
            int count = 0;
            int[] allElements = new int[n];
            for (int i = 0; i < n; i++)
            {

                allElements[i] = int.Parse(Console.ReadLine());
                if (allElements[i]<0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
