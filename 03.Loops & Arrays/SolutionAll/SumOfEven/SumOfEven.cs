using System;

namespace SumOfEven
{
    class SumOfEven
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[6];
            int sum = 0;
            
            for(; ; )
            {
                #region Inputing & Converting Numbers
                Console.WriteLine("Enter a first number!");
                string num1 = Console.ReadLine();
                
                Console.WriteLine("Enter a second number!");
                string num2 = Console.ReadLine();

                Console.WriteLine("Enter a third number!");
                string num3 = Console.ReadLine();

                Console.WriteLine("Enter a fourth number!");
                string num4 = Console.ReadLine();

                Console.WriteLine("Enter a fifth number!");
                string num5 = Console.ReadLine();

                Console.WriteLine("Enter a sixth number!");
                string num6 = Console.ReadLine();

                bool conversionOne = int.TryParse(num1, out int firstConversion);
                bool conversionTwo = int.TryParse(num2, out int secondConversion);
                bool conversionThree = int.TryParse(num3, out int thirdConversion);
                bool conversionFour = int.TryParse(num4, out int fourthConversion);
                bool conversionFive = int.TryParse(num5, out int fifthConversion);
                bool conversionSix = int.TryParse(num6, out int sixthConversion);

                #endregion
                if (conversionOne && conversionTwo && conversionThree && conversionFour && conversionFive && conversionSix)
                {
                    arrayOfNumbers[0] = firstConversion;
                    arrayOfNumbers[1] = secondConversion;
                    arrayOfNumbers[2] = thirdConversion;
                    arrayOfNumbers[3] = fourthConversion;
                    arrayOfNumbers[4] = fifthConversion;
                    arrayOfNumbers[5] = sixthConversion;

                    for (int i = 0; i < arrayOfNumbers.Length; i++)
                    {
                        if(arrayOfNumbers[i] % 2 == 0)
                        {
                            sum += arrayOfNumbers[i];
                        }
                    }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The sum of the even numbers is: " + sum);
                        Console.ResetColor();

                    break;
                }
            }
                Console.ReadLine();
        }
    }
}
