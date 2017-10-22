using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double lastNum = 0;
            int plus = 0;
            int minus = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > lastNum)
                {
                    plus++;
                }
                else
                {
                    minus++;
                }
                lastNum = numbers[i];
            }

            if (minus != 0)
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
