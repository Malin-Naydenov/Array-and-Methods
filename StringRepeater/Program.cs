using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string readyWord = RepeatString(word, count);
            Console.WriteLine(readyWord);

        }
        static string RepeatString(string word, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += word;
            }

            return repeatedString;
        }

    }
}
