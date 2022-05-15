using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_excersises
{
    class Order
    {
        private OrderItem[] items;

        public Order(OrderItem[] items)
        {
            this.items = items;
        }

        public void PrintOrder()
        {
            decimal total = 0;
            foreach (var item in items)
            {
                if (item is not null)
                {
                    Console.WriteLine(item.ToString());
                    total += item.GetValue();

                }
            }
            Console.WriteLine($"Wartość zamówienia wynosi: {total}");
        }
    }
}
