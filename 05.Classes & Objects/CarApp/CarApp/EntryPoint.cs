using System;
using CarApp.Classes;
using System.Linq;


namespace CarApp
{
    internal class EntryPoint
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Choose a Driver: ");
            string driverChoice = Console.ReadLine().ToLower();
            Console.WriteLine("Choose a Car no.1: ");
            string carChoice = Console.ReadLine().ToLower();
            Console.WriteLine("Choose a Car no.2: ");
            string carChoice2 = Console.ReadLine().ToLower();

            Driver Bob = new Driver("Bob", 10);
            Driver Greg = new Driver("Greg", 15);
            Driver Jill = new Driver("Jill", 20);
            Driver Anne = new Driver("Anne", 50);

            Car Hyundai = new Car("Hyundai", 120, driverChoice, carChoice, Bob.Skill);
            Car Mazda = new Car("Mazda", 150, driverChoice, carChoice, Greg.Skill);
            Car Ferrari = new Car("Ferrari", 250, driverChoice, carChoice2, Jill.Skill);
            Car Porsche = new Car("Porsche", 200, driverChoice, carChoice2, Anne.Skill);

            Hyundai.CalculateSpeed();
            Mazda.CalculateSpeed();















            Console.ReadLine();
        }
        
    }
}