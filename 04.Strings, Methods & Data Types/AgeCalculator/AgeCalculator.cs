using System;

namespace AgeCalculator
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            DateTime utcNow = DateTime.UtcNow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter your birthday date!");
            DateTime inputtedDate = DateTime.Parse(Console.ReadLine());
            Console.ResetColor();

            AgeCalculator(inputtedDate, utcNow);
        }

        private static void AgeCalculator(DateTime inputtedDate, DateTime utcNow)
        {
            int result = utcNow.Year - inputtedDate.Year;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You are : {result} years old!");
            Console.ResetColor();
            
            Console.ReadLine();
        }
    }
}