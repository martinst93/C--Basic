using System;

namespace RealCalculator
{
    class RealCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the first number!");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Please enter the second number!");
            string secondNum = Console.ReadLine();

            Console.WriteLine("Please enter the operation you wish to execute!");
            string operation = Console.ReadLine();

            bool conversionOne = int.TryParse(firstNum,  out int firstConversion);
            bool conversionTwo = int.TryParse(secondNum, out int secondConversion);

            if ((conversionOne && conversionTwo) || operation == "+" + "-" + "*" + "/")
            {
                if (operation == "+")
                {
                    Console.WriteLine("The result is: " + (firstConversion + secondConversion));
                }
                else if (operation == "-")
                {
                    Console.WriteLine("The result is: " + (firstConversion - secondConversion));
                }
                else if (operation == "*")
                {
                    Console.WriteLine("The result is: " + (firstConversion * secondConversion));
                }
                else if (operation == "/")
                {
                    Console.WriteLine("The result is: " + (firstConversion / secondConversion));
                }
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong!");
                Console.ResetColor();
            }




            Console.ReadLine();
        }
    }
}
