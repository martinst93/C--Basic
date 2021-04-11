using System.Collections.Generic;

namespace Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Department Department { get; set; }

        public Manager(string firstName, string lastName, double salary, Department department) 
            : base(firstName, lastName, Role.Manager, salary)
        {
            Department = department;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}