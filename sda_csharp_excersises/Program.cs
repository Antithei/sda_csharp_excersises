using System;
using System.Linq;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution1();
            Console.WriteLine(" ");
            Solution2();
        }
        static void Solution1()
        {
            int[] numbers = { 2, 5, 1, 2, 5 };

            int[] result = numbers.Distinct().ToArray();
            foreach (int num in result)
            {
                Console.Write(num);
            }
        }
        static void Solution2()
        {
            int[] numbers = { 2, 5, 1, 2, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        numbers[j] = -1;
                    }
                }
                if (numbers[i] >= 0)
                {
                    Console.Write(numbers[i]);
                }
            }
        }

    }
}