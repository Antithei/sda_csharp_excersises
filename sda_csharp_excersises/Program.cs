using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 6;
            int first = 4;
            int diff = 2;
            ArithmeticProgression(lenght, first, diff);
        }

        static void ArithmeticProgression(int lenght, int first, int diff)
        {
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(first);
                first += diff;
            }
        }
    }
}
