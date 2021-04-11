using System;
using DocuSign.eSign.Model;
using Models;

namespace Exercise
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Bob", "Bobsky", Role.Other, 600);
            Employee employee2 = new Employee("Karen", "Ross", Role.Other, 600);
            Employee employee3 = new Employee("Sean", "Anderson", Role.Other, 600);
            SalesPerson salesPerson = new SalesPerson("Peter", "Pan", 2000);
            Contractor contractor = new Contractor("Emily", "Quinn", 180, 20, new Manager("Deborah", "Wallace", 600, Department.Recruiter));
            Contractor contractor2 = new Contractor("Mel", "Penn", 180, 20, new Manager("Robin", "Williams", 600, Department.Recruiter));
            CEO ceo = new CEO("Les", "Mooney", 3000, 25, 1000, new string[]{ "Bob Bobert", "Rick Rickert", "Mona Monalisa", "Igor Igorsky", "Lea Leova" } );

            Manager manager = new Manager("David", "Stone", 2000, Department.Recruiter);

            Department department = contractor.Responsible.Department;
            contractor.CurrentPosition(department);

            /*salesPerson.ExtendSuccessRevenue(2000);
            manager.AddBonus(4000);
            salesPerson.ExtendSuccessRevenue(3000);

            Console.WriteLine(employee.GetInfo());
            Console.WriteLine(salesPerson.GetInfo());
            Console.WriteLine(manager.GetInfo());

            Console.WriteLine($"Employee salary: {employee.GetSalary()}");
            Console.WriteLine($"SalesPerson salary: {salesPerson.GetSalary()}");
            Console.WriteLine($"Manager salary: {manager.GetSalary()}");
            Console.WriteLine($"Contractor salary is {contractor.GetSalary()}");*/

            Console.WriteLine($"CEO: {ceo.PrintInfo()}");
            Console.WriteLine($"Salary of the CEO is: {ceo.GetSalary()}");
            Console.WriteLine($"New Shares Price: {ceo.AddSharesPrice(123)}");
            ceo.PrintEmployees();

            Console.ReadLine();
        }
    }
}