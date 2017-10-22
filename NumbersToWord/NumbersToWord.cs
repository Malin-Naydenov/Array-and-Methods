using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWord
{
    class NumbersToWord
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] digit1 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thrirtee", "fourteen", "fivteen", "sixteen", "seventeeen", "eighteen", "nineteen" };
            string[] digit2 = { "zero", "one", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eightty", "ninety" };

            string firstMemory = "";
            string secondMemory = "";
            string thirdMemory = "";
            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                int number =  Math.Abs(input);

                if (input > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (input < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (input > -100 && input< 100)
                {
                    
                    continue;
                }

                

                else
                {



                    int firstDigit = number / 100;
                    int secondDigit = (number % 100) / 10;
                    int thirdDigit = (number % 100) % 10;

                    firstMemory = digit1[firstDigit];


                    if (input < 0)
                    {

                        if (secondDigit < 2 && secondDigit > -2)
                        {
                            int zeroToTwenty = (secondDigit * 10) + thirdDigit;
                            secondMemory = digit1[zeroToTwenty];
                            if(secondDigit==0 && thirdDigit==0)
                            {
                                Console.WriteLine($"minus {firstMemory}-hundred");
                            }
                            else
                            {
                            Console.WriteLine($"minus {firstMemory}-hundred and {secondMemory}");

                            }
                        }
                        else
                        {
                            secondMemory = digit2[secondDigit];
                            thirdMemory = digit1[thirdDigit];

                            if (thirdMemory == digit1[0])
                            {
                                Console.WriteLine($"minus {firstMemory}-hundred and {secondMemory}");
                            }
                            else
                            {

                                Console.WriteLine($"minus {firstMemory}-hundred and {secondMemory} {thirdMemory}");
                            }
                        }
                    }

                    else
                    {

                        if (secondDigit < 2 && secondDigit > -2)
                        {
                            int zeroToTwenty = (secondDigit * 10) + thirdDigit;
                            secondMemory = digit1[zeroToTwenty];
                            if (secondDigit == 0 && thirdDigit == 0)
                            {
                                Console.WriteLine($"{firstMemory}-hundred");
                            }
                            else
                            {
                            Console.WriteLine($"{firstMemory}-hundred and {secondMemory}");

                            }
                        }
                        else
                        {
                            secondMemory = digit2[secondDigit];
                            thirdMemory = digit1[thirdDigit];
                            if (thirdMemory == digit1[0])
                            {
                                Console.WriteLine($"{firstMemory}-hundred and {secondMemory}");
                            }
                            else
                            {

                                Console.WriteLine($"{firstMemory}-hundred and {secondMemory} {thirdMemory}");
                            }
                        }
                    }
                }
            }
        }
    }
}





