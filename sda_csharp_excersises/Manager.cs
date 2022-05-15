using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_excersises
{
    class Manager : Employee
    {
        public Manager(string firstName, string lastName, int yearOfBirth, decimal salary) 
            : base(firstName, lastName, yearOfBirth, salary)
        {
            System.Console.WriteLine($"{nameof(Manager)} created with parameters");
        }

        public override decimal GetTotalSalary()
        {
            return Salary*1.10M;
        }
    }
}
