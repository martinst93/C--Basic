using System;

namespace StudentGroup
{
    class StudentGroup
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[] { "\nJack \n", "Mary \n", "Steve \n", "Ashley \n", "Ed \n" };
            string[] studentsG2 = new string[] { "\nTod \n", "Stacy \n", "Emily \n", "Andy \n", "Janice \n" };
            string sum = "";

            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter student group: ( there are 1 and 2 )");
                string number = Console.ReadLine();
                Console.ResetColor();

                bool conversion = int.TryParse(number, out int convertedNum);

                if (conversion == true)
                {
                    if(convertedNum == 1)
                    {
                        for (int i = 0; i < studentsG1.Length; i++)
                        {
                            sum += studentsG1[i];
                        }
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("The Students in G1 are: " + sum);
                            Console.ResetColor();
                    }

                    else if (convertedNum == 2)
                    {
                        for (int i = 0; i < studentsG2.Length; i++)
                        {
                            sum += studentsG2[i];
                        }
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("The Students in G2 are: "  + sum);
                            Console.ResetColor();
                    }
                break;
                }
            }
            Console.ReadLine();
        }
    }
}
