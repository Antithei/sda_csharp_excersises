namespace sda_csharp_excersises
{
    class Employee : Person
    {
        public decimal Salary { get; set; }

        //public Employee()
        //{
        //    System.Console.WriteLine($"{nameof(Employee)} created without parameters");
        //}

        public Employee(string firstName, string lastName, int yearOfBirth, decimal salary)
            :base(firstName, lastName, yearOfBirth)
        {
            Salary = salary;
            System.Console.WriteLine($"{nameof(Employee)} created with parameters");
        }
    }
}
