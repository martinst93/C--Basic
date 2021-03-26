using System;

namespace SwapNumbers
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the first number!");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Please enter the second number!");
            string secondNum = Console.ReadLine();

            bool conversionOne = int.TryParse(firstNum, out int firstConversion);
            bool conversionTwo = int.TryParse(secondNum, out int secondConversion);

            if (conversionOne && conversionTwo)
            {
                int container1 = firstConversion;
                int container2 = secondConversion;
                secondConversion = container1;
                firstConversion = container2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("First Number: " + firstConversion);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Second Number: " + secondConversion);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong!");
            }



            Console.ReadLine();
        }
    }
}
