﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementsInArray
{
    class CountOfGivenElementInArray
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
