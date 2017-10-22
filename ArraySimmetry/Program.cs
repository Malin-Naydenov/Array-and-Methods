using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySimmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            bool symetric = true;

            for (int i = 0; i < input.Length/2; i++)
            {
                if(input[i] != input[input.Length-i-1])
                {
                    symetric = false;
                }
            }
            if(symetric  == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
