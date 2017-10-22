using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalisticTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] target = Console.ReadLine().Split(' ').Select(double.Parse).ToArray(); 
            

            string[] weapon = Console.ReadLine().Split().ToArray();
            double cordinat = double.Parse(weapon[1]);

            double xCordinat = 0;
            double yCordinat = 0;

            for (int i = 1; i < weapon.Length-1; i+=2)
            {
                if(i % 2 == 0 && weapon[i]== "right")
                {
                    xCordinat += double.Parse(weapon[i + 1]);
                }
                else if (i%2 == 0 && weapon[i] == "left")
                {
                    xCordinat -= double.Parse(weapon[i + 1]);
                }
                else if (i % 2 == 0 && weapon[i] == "up")
                {
                    yCordinat += double.Parse(weapon[i + 1]);
                }
                else if (i % 2 == 0 && weapon[i] == "down")
                {
                    yCordinat -= double.Parse(weapon[i + 1]);
                }

            }
            if (xCordinat == target[0] && yCordinat == target[1])
            {
                Console.WriteLine($"firing at [{target[0]}, {target[1]}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{target[0]}, {target[1]}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
