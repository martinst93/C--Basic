using System;

namespace AverageNumber
{
    class AverageNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the first number!");
            string firstNum = Console.ReadLine();

            Console.WriteLine("Please enter the second number!");
            string secondNum = Console.ReadLine();

            Console.WriteLine("Please enter the third number!");
            string thirdNum = Console.ReadLine();

            Console.WriteLine("Please enter the fourth number!");
            string fourthNum = Console.ReadLine();

            bool conversionOne = int.TryParse(firstNum, out int firstConversion);
            bool conversionTwo = int.TryParse(secondNum, out int secondConversion);
            bool conversionThree = int.TryParse(thirdNum, out int thirdConversion);
            bool conversionFour = int.TryParse(fourthNum, out int fourthConversion);

            if (conversionOne && conversionTwo && conversionThree && conversionFour)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Average sum of " + firstConversion + "," + secondConversion + " " + thirdConversion + " and " + fourthConversion + " is: " + ((firstConversion + secondConversion + thirdConversion + fourthConversion) / 4));
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
