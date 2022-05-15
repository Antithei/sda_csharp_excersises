using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Cerberus"),
                new Cat("Collin"),
                new Dog("Lilka"),
                new Cat("Catie")
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
                if(animal is Dog dog)
                {
                    Console.WriteLine("Pies^");
                }
                else if(animal is Cat cat)
                {
                    Console.WriteLine("Kot^");
                }
            }
        }
    }
}
