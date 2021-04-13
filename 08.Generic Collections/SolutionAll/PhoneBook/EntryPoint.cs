using System;
using System.Collections.Generic;

namespace Exercise01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<long, string> phoneBook = new Dictionary<long, string>
            {
                {72123456, "Risto"},
                {70654321, "Adis" },
                {71123456, "Martin" },
                {76123456, "Nikola" },
                {76654321, "Aleksandar" }
            };

            Console.WriteLine("Search: ");
            string search = Console.ReadLine();

            bool cast = long.TryParse(search, out long number);
            bool phoneFound = false;

            if (cast)
            {
                //phoneBook[number]
                bool numberFound = phoneBook.TryGetValue(number, out string name);

                if (numberFound)
                {
                    Console.WriteLine($"{name}: {number}");
                    phoneFound = true;
                }
            }
            else
            {
                foreach (var phoneNumber in phoneBook)
                {
                    if (phoneNumber.Value == search)
                    {
                        Console.WriteLine($"{phoneNumber.Value}: {phoneNumber.Key}");
                        phoneFound = true;
                        break;
                    }
                }

                //Default [0, null]
                //KeyValuePair<long, string> foundNumber = phoneBook.FirstOrDefault(x => x.Value == search);

                //if (foundNumber.Value != null)
                //{
                //    Console.WriteLine($"{foundNumber.Value}: {foundNumber.Key}");
                //    phoneFound = true;
                //}
            }

            if (!phoneFound)
                Console.WriteLine("Phone not found");

            Console.WriteLine("Do you want to input a number?");
            Console.WriteLine("For Yes please enter Y, and for no please enter N");
            string yesOrNo = Console.ReadLine().ToUpper();

            if (yesOrNo == "Y")
            {
                Console.WriteLine("Please enter the new number.");
                string inputNumber = Console.ReadLine();

                bool newNumberCheck = long.TryParse(inputNumber, out long newNumber);
                Console.WriteLine("Please enter the name of the person.");
                string inputName = Console.ReadLine().Trim();

                if (inputName.Contains("0") || inputName.Contains("1") || inputName.Contains("2") || inputName.Contains("3") ||
                    inputName.Contains("4") || inputName.Contains("5") || inputName.Contains("6") || inputName.Contains("7") ||
                    inputName.Contains("8") || inputName.Contains("9") || inputName.Contains("$") || inputName.Contains("#") ||
                    inputName.Contains("*"))
                {
                    Console.WriteLine("Please enter letters not numbers for the name");
                }

                if (!newNumberCheck)
                {
                    Console.WriteLine("Please enter a number");
                }
                else if (newNumberCheck == true)
                {
                    string conNum = newNumber.ToString();
                    if (conNum.Length < 8 || conNum.Length > 8)
                    {
                        Console.WriteLine("The new number must contain 8 digits");
                    }
                    else if (conNum.Length == 8)
                    {
                        long.TryParse(conNum, out long newConvertedNumber);
                        phoneBook.Add(newConvertedNumber, inputName);
                        Console.WriteLine($"The number: {newConvertedNumber} and the name: {inputName} have been added to the phone book!");
                    }
                }
            }
            else if (yesOrNo == "N") { return; }
            Console.ReadLine();
        }
    }
}