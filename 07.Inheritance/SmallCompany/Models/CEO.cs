using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CEO : Employee
    {
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public string[] Employees { get; set; } 

        public CEO()
        {

        }

        public CEO(string firstName, string lastName, double salary, int shares, double sharesPrice, string[] employees)
            : base(firstName, lastName, Role.CEO, salary)
        {
            Shares = shares;
            SharesPrice = sharesPrice;
            Employees = employees;
        }

        public double AddSharesPrice(double newPrice)
        {
            return SharesPrice = newPrice;
        }

        public void PrintEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"{Employees[i]}");
            }
        }

        public override double GetSalary()
        {
            return Salary = Salary + (Shares * SharesPrice);
        }

        public string PrintInfo()
        {
            return ($"First Name: {FirstName} Last Name: {LastName} Salary: {Salary}"); 
        }
    }
}
