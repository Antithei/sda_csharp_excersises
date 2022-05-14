using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 6, 9, 14, 2, 7, 4, 8 };
            BubbleSort(numbers);
            foreach (int number in numbers) Console.Write($"{number} ");

        }

        static void BubbleSort(int[] numbers)
        {
            int temp;
            for (int i = numbers.Length - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
        }
    }
}
