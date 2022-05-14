using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
        
        static int Factorial(int number)
        {
            if (number == 0) return 1;
            else return number * Factorial(number - 1);
        }
    }
}
