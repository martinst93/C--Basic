using System;

namespace Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible) 
            : base(firstName, lastName, Role.Contractor, 700)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }

        public void CurrentPosition(Department department)
        {
            Console.WriteLine($"The department of the manager that is responsible for this Contractor is {department} department."); 
        }
    }
}
