using System;

namespace CarApp.Classes

{
    public class Car : Driver
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        public Car(string model, int speed, string driver, string name, int skill)
            : base(name, skill)

        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public void CalculateSpeed()
        {
            int result = this.Speed * this.Skill;
            Console.WriteLine($"Result is: {result}");
        }
    }
}