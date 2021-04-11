namespace Models
{
    public class Company : Employee
    {
        public Company[] employee;

        public Company(string firstName, string lastName, Role role, double salary) : base(firstName, lastName, Role.Contractor, 700)
        {
            employee = new Company[5];
            employee[0] = new Company("John", "Johnson", Role.Contractor, 600);
            employee[1] = new Company("Sandy", "Taylor", Role.Contractor, 600);
            employee[2] = new Company("Mandy", "Manson", Role.Manager, 600);
            employee[3] = new Company("Mark", "Diaz", Role.Manager, 600);
            employee[4] = new Company("Joe", "Quinn", Role.Sales, 2000);
        }
    }
}
