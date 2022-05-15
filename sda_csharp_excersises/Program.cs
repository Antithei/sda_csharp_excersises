using System;

namespace sda_csharp_excersises
{
    class Program
    {
        static void Main(string[] args)
        {

            OrderItem[] items = new OrderItem[3];
            items[0] = new OrderItem("chleb", 5, 3.50M);
            items[1] = new OrderItemWithPackage("mleko", 5, 2.20M, "butelka", 1.00M);

            Order order = new Order(items);

            order.PrintOrder();
            //OrderItem chleb = new("chleb", 3, 2.50M);

            //Console.WriteLine(chleb.ToString());
            Console.ReadLine();
        }
    }
}
