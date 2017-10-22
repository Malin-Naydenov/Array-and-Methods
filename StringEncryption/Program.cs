using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            char[] allLetter = new char[inputNum];




            for (int i = 0; i < inputNum; i++)
            {
                allLetter[i] = char.Parse(Console.ReadLine());

                int number = allLetter[i];
                int beforeLetters = 0;
                int afterLetters = 0;
                if (number < 100)
                {
                    int Digit1 = number / 10;
                    int Digit2 = number % 10;
                    beforeLetters = number - Digit1;
                    afterLetters = number + Digit2;

                    char beforeASCIIletter = (char)beforeLetters;
                    char afterASCIIletter = (char)afterLetters;
                    Console.Write($"{afterASCIIletter}" + number + $"{beforeASCIIletter}");
                }

                else
                {

                    int firstDigit = number / 100;
                    int secondDigit = (number % 100) / 10;
                    int thirdDigit = (number % 100) % 10;

                    int lastAndFirst = firstDigit * 10 + thirdDigit;



                    beforeLetters = number - firstDigit;
                    afterLetters = number + thirdDigit;

                    char beforeASCIIletter = (char)beforeLetters;
                    char afterASCIIletter = (char)afterLetters;

                    Console.Write($"{afterASCIIletter}" + lastAndFirst + $"{beforeASCIIletter}");
                }
                
            }
        }
    }
}
