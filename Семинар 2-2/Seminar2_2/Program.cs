using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            do
            {
                Console.WriteLine("Введите через пробел название, цену и количество товара, чтобы добавить его в корзину\nВведите \"Всё\", чтобы выйти");
                string input = Console.ReadLine();
                if (input == "Всё")
                {
                    break;
                }

                string[] itemParams = input.Split(' ');
                if (itemParams.Length > 2
                    && double.TryParse(itemParams[1], out double price)
                    && int.TryParse(itemParams[2], out int quantity))
                {
                    shoppingCart.AddToCart(itemParams[0], price, quantity); // это композиция

                    //// это агрегация
                    //Item item = new Item(itemParams[0], price, quantity);
                    //shoppingCart.AddToCart(item);
                }

            } while (true);

            Console.WriteLine($"Общая стоиомость товаров {shoppingCart.TotalPrice}");
            Console.WriteLine("Список товаров:");
            for (int i = 0; i < shoppingCart.Size; ++i)
            {
                Console.WriteLine(shoppingCart[i]);
            }
        }
    }
}
