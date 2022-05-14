using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            triangle("*", 7);
        }

        static void triangle(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++) Console.Write(symbol);
                Console.WriteLine();
            }
            for (int i = size; i > 0; i--)
            {
                for (int j = i; j > 0; j--) Console.Write(symbol);
                Console.WriteLine();
            }
        }
    }
}
