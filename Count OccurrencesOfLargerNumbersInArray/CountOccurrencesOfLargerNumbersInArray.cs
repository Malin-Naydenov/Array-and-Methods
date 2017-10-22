using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_OccurrencesOfLargerNumbersInArray
{
    class CountOccurrencesOfLargerNumbersInArray
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double comparator = double.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > comparator)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
