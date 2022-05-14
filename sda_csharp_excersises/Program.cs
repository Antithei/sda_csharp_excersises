using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj podstawę potęgi: ");
            int podstawa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wykładnik potęgi: ");
            int wykładnik;
            do
            {
                wykładnik = Convert.ToInt32(Console.ReadLine());
            } while (wykładnik <= 0);
            potęga(podstawa, wykładnik);
        }

        static void potęga(int podstawa, int wykładnik)
        {
            int potęga = podstawa;
            for (int i = 1; i < wykładnik; i++)
            {
                potęga = potęga * podstawa;
            }
            Console.WriteLine($"Potęga o podanych danach wynosi: {potęga}");
        }
    }
}
