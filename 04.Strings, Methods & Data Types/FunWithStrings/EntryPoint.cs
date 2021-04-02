using System;
using System.Linq;

namespace FunWithStrings
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Enter some sentence");
            string input = Console.ReadLine().ToLower();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter the sentence you want to trim");
            string input2 = Console.ReadLine().ToLower();
            Console.ResetColor();

            RemoveExtraSpace(input2);
            FunWithStrings(input);
        }
        static void FunWithStrings(string input)
        {
            string[] longWord;

            int ni = 0, no = 0, len, max = 0, total = 0;

            string reversed = new string(input.Reverse().ToArray());
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(reversed);
            Console.ResetColor();

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Contains("a") || input.Contains("e") || input.Contains("i") || input.Contains("o") || input.Contains("u"))
                {
                    total++;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Your total number of vowels is: {0}", total);
            Console.ResetColor();

            if (input == reversed)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The word/words are palindrome");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The word/words are not a palindrome");
                Console.ResetColor();
            }

            longWord = input.Split(' ');
            len = longWord.Length;

            for (int i = 0; i < len; i++)
            {
                if (longWord[i].Length > max)
                {
                    max = longWord[i].Length;
                    ni = i;
                }
                if (longWord[i].Length < max)
                {
                    max = longWord[i].Length;
                    no = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Shortest string is  string:{0} \n Count of count of character:{1}", longWord[no], max);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Longest string:{0} \n Count of count of character:{1}", longWord[ni], max);
            Console.ResetColor();
            Console.ReadLine();
        }
        static void RemoveExtraSpace(string input2)
        {
            char[] charsToTrim = { 'a', 'b', 'o', 'v', 'e', ',', 't', 'h', 'e', 'n', 'g', 'e', 't', 'y', 'e', 'r', 'p', 'i', 'r', 'a', 't', 'e' };
            string trimed = new string(input2.Trim(charsToTrim).Replace(" ", ""));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Trimmed Sentence: " + trimed);
            Console.ResetColor();
        }
    }
}
