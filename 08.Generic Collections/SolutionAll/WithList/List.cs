﻿using System;
using System.Collections.Generic;

namespace Exercise01
{
    public class List
    {
        public static void Main(string[] args)
        {
            List<long> newPhone = new List<long>()
            {
            };

            for (; ; )
            {
                Console.WriteLine("Do you want to input a number?");
                Console.WriteLine("For Yes please enter Y, and for no please enter N");
                string yesOrNo = Console.ReadLine().ToUpper().Trim();

                if (yesOrNo == "Y")
                {
                    Console.WriteLine("Please input a number ");

                    string inputNumber1 = Console.ReadLine();
                    string inputNumber2 = Console.ReadLine();
                    string inputNumber3 = Console.ReadLine();
                    string inputNumber4 = Console.ReadLine();

                    bool firstCon = long.TryParse(inputNumber1, out long ConvertedNumber);
                    bool secondCon = long.TryParse(inputNumber2, out long ConvertedNumber2);
                    bool thirdCon = long.TryParse(inputNumber3, out long ConvertedNumber3);
                    bool fourthCon = long.TryParse(inputNumber4, out long ConvertedNumber4);

                    if (firstCon && secondCon && thirdCon && fourthCon)
                    {
                        newPhone.Add(ConvertedNumber);
                        newPhone.Add(ConvertedNumber2);
                        newPhone.Add(ConvertedNumber3);
                        newPhone.Add(ConvertedNumber4);

                        foreach (object number in newPhone)
                        {
                            Console.WriteLine($"The numbers are {number}");
                        }
                    }
                    else { Console.WriteLine("You must enter numbers"); continue; }
                }
                else
                {
                    break;
                }
                break;
            }

            Console.ReadLine();
        }
    }
}