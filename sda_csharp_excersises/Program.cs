using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj cenę produktu: ");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("podaj liczbe linii: ");
                int lines = Convert.ToInt32(Console.ReadLine());
                PriceList(price, lines);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PriceList(int price, int lines)
        {
            for(int i=1;i<=lines;i++)
            {
                Console.WriteLine($"Liczba sztuk: {i} łączna cena: {i*price}zł.");
            }
        }
    }
}
