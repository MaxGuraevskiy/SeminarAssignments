using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2_2
{
    class ShoppingCart
    {
        private const int DEFAULT_CAPACITY = 5;

        private Item[] _cart;
        public int Size { get; private set; }
        public double TotalPrice { get; set; }

        public ShoppingCart()
        {
            _cart = new Item[DEFAULT_CAPACITY];
            Size = 0;
            TotalPrice = 0;
        }

        private void IncreaseSize()
        {
            Array.Resize(ref _cart, _cart.Length + 3);
        }

        public void AddToCart(string name, double price, int quantity)
        {
            Item itemToAdd = new Item(name, price, quantity);
            AddToCart(itemToAdd);
        }

        public void AddToCart(Item item)
        {
            if (Size == _cart.Length)
            {
                IncreaseSize();
            }

            _cart[Size++] = item;
            TotalPrice += item.Price * item.Quantity;
        }

        public string this[int i]
        {
            get {
                if (i >= 0 && i < _cart.Length)
                {
                    return _cart[i].ToString();
                }

                throw new IndexOutOfRangeException();
            }
        }
    }
}
