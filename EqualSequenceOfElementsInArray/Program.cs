using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int check = numbers[0];
            int negativeCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] != check)
                {
                    negativeCount++;
                }
                check = numbers[i];
            }
            if (negativeCount != 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
