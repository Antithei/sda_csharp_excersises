using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.FirstName = "Jan"; //set
            //person.FirstName = ""; //imię nie ulegnie zmianie
            //Console.WriteLine(person.FirstName); //get

            //Person person = new Person();
            //var person = new Person();

            Person[] guests = new Person[]
            {
                new Person("Jan", "Kowalski", 1990),
                new Employee("Adam", "Nowak", 2000, 5_000.00M),
                new Person(),
                new Person
                {   //blok inicjalizacyjny konstruktora
                    FirstName = "Ewa",
                    LastName = "Niedźwiecka",
                    YearOfBirth = 2010
                }
            };

            Console.WriteLine("---------------------------");

            foreach (var guest in guests)
            {
                guest.WhoAmI();
                if (guest is Employee employee)
                {
                    Console.WriteLine($"Salary: {employee.Salary}");
                }
            }

            Console.WriteLine("---------------------");
            PrintHello(guests);
        }

        static void PrintHello(Person[] guests)
        {
            foreach (var guest in guests)
            {
                if (guest.IsAdult()) Console.WriteLine("Witaj w sklepie monopolowym");
                else Console.WriteLine("Witaj w sklepie zabawkowym");
            }
        }
    }
}
