using System;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Enter the second number");
            string secondNum = Console.ReadLine();

            bool conversionOne = int.TryParse(firstNum, out int convertedFirstNum);
            int.TryParse(secondNum, out int convertedSecondNum);

            if (!conversionOne)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong!");
                Console.ResetColor();
            } 
            else
            {
                if (convertedFirstNum > convertedSecondNum)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The Larger Number is: " + convertedFirstNum);
                    Console.ResetColor();

                    if (convertedFirstNum % 2 == 0)
                    {
                        Console.WriteLine("The Larger Number is even");
                    }
                    else
                    {
                        Console.WriteLine("The Larger Number is odd");
                    }
                }
                else if (convertedFirstNum < convertedSecondNum)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The Larger Number is: " + convertedSecondNum);
                    Console.ResetColor();

                    if (convertedSecondNum % 2 == 0)
                    {
                        Console.WriteLine("The Larger Number is even");
                    }
                    else
                    {
                        Console.WriteLine("The Larger Number is odd");
                    }
                }
                else if (convertedFirstNum == convertedSecondNum)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The Numbers Are Equal");
                    Console.WriteLine(" This is the first number : " + convertedFirstNum + " This is the second number: " + convertedSecondNum);
                    Console.ResetColor();
                }
            }




            Console.ReadLine();
        }
    }
}
