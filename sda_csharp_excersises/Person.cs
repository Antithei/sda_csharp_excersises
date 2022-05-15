using System;

namespace sda_csharp_excersises
{
    class Person
    {
        private const int PROPER_AGE = 18;
        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(message: nameof(FirstName));
                }
                _firstName = value;

            }
        }

        public string LastName { get; set; }

        public int YearOfBirth { get; set; }

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}.");
        }

        public bool IsAdult()
        {
            if (DateTime.Now.Year - YearOfBirth >= PROPER_AGE) return true;
            else return false;
        }

        // public bool IsAdult => (DateTime.Now.Year) - YearOfBirth >= PROPER_AGE;

        public Person()
        {
            Console.WriteLine($"{nameof(Person)} created without parameters");
        }

        public Person(string firstName, string lastName,int yearOfBirth)
        {
            _firstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            Console.WriteLine($"{nameof(Person)} created with parameters");
        }
    }
}
