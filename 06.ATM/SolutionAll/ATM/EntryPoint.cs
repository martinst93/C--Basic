using ATM.Classes;
using System;

namespace ATM
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            Customers[] customer = new Customers[4]
             {
                new Customers("Ken Pen", "1234-1234-1234", 1234, 500),
                new Customers("Robin White", "4444-4444-4444", 4444, 600),
                new Customers("Bill Smith", "5555-5555-5555", 5555, 700),
                new Customers("Howard Stern", "7777-7777-7777", 7777, 800),
             };

            Console.WriteLine("Enter your card number");
            string cardNumberInput = Console.ReadLine();
            Console.WriteLine("Enter your PIN number");
            string pinNumber = Console.ReadLine();
            Console.WriteLine($"Enter the operation you wish to do \n 1.Check Balance\n 2.Cash Withdrawal\n 3.Cash Deposition");

            string operation = Console.ReadLine();

            int pinConverted = Int32.Parse(pinNumber);
            int convertedOperation = Int32.Parse(operation);

            Validation(customer, cardNumberInput, pinConverted, convertedOperation);

            Console.ReadLine();
        }

        private static void Validation(Customers[] customer, string cardNumberInput, int pinConverted, int convertedOperation)
        {
            foreach (var item in customer)
            {
                if (cardNumberInput == item.CardNumber && pinConverted == item.PinNumber)
                {
                    Console.WriteLine($"Welcome {item.Name}!");

                    switch (convertedOperation)
                    {
                        case 1:
                            BalanceChecking(customer, cardNumberInput);
                            break;

                        case 2:
                            CashWithdrawal(customer, cardNumberInput);
                            break;

                        case 3:
                            CashDeposition(customer, cardNumberInput);
                            break;

                        default:
                            Console.WriteLine("---------");
                            break;
                    }
                }
            }
        }

        private static void BalanceChecking(Customers[] customer, string creditCard)
        {
            for (var i = 0; i < customer.Length; i++)
            {
                if (customer[i].CardNumber == creditCard)
                    Console.WriteLine($"The Balance of your account is: ${customer[i].Balance}");
            }
        }

        private static void CashWithdrawal(Customers[] customer, string cardNumberInput)
        {
            Console.WriteLine("Enter the amount of money you wish to withdraw");
            string withdrawAmountInput = Console.ReadLine();

            int con = Int32.Parse(withdrawAmountInput);
            int res;

            foreach (var item in customer)
            {
                if (item.CardNumber == cardNumberInput)
                {
                    if (con <= item.Balance)
                    {
                        res = item.Balance - con;
                        Console.WriteLine($"you have withdrawn ${con}");
                        Console.WriteLine($"You have ${res} left in your account balance");
                    }
                    else
                    {
                        Console.WriteLine($"You don't have enough cash in your account!");
                    }
                }
            }
        }

        private static void CashDeposition(Customers[] customer, string cardNumberInput)
        {
            Console.WriteLine("Enter the amount of money you wish to deposit");
            string depositInput = Console.ReadLine();

            int con = Int32.Parse(depositInput);
            int res;
            foreach (var item in customer)
            {
                if (cardNumberInput == item.CardNumber)
                {
                    Console.WriteLine($"You have deposited ${con} into your account!");
                    res = item.Balance + con;
                    Console.WriteLine($"You have ${res} in your account!");
                }
            }
        }
    }
}