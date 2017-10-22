using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElementInArrey
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());
            int largestNum = GetLargestElement(countNumber);
            Console.WriteLine(largestNum);
        }

        static int GetLargestElement(int countNumber)
        {
            int[] nextNumbers = new int [countNumber];
            int largestNum = int.MinValue;
            for (int k = 0; k < countNumber; k++)
            {
                nextNumbers[k] = int.Parse(Console.ReadLine());

            }
            

            for (int i = 0; i < nextNumbers.Length; i++)
            {
                var courentNumber = nextNumbers[i];
                if (courentNumber>largestNum)
                {
                    largestNum = courentNumber;
                }
            }
            return largestNum;

        }
    }
}
