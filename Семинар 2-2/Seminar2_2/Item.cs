using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2_2
{
    class Item
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }

        public Item(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Товар \"{Name}\" по цене {Price} за {Quantity} штук стоит {Price * Quantity}";
        }
    }
}
