using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Classes
{
    public class Customers
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public int PinNumber { get; set; }
        public int Balance { get; set; }
        
        
        public Customers(string name, string cardNumber, int pinNumber, int balance)
        {
            Name = name;
            CardNumber = cardNumber;
            PinNumber = pinNumber;
            Balance = balance;
        }
    }
}
