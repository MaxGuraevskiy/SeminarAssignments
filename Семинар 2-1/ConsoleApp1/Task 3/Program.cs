using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static int ReadInt(string message, int limit = int.MinValue)
        {
            int number;
            do
            {
                Console.Write(message);
            }
            while (!int.TryParse(Console.ReadLine(), out number) || number < limit);

            return number;
        }

        static void Main(string[] args)
        {
            Polygon polygon = new Polygon();
            Console.WriteLine("По умолчанию создан многоугольник: ");
            Console.WriteLine(polygon.PolygonData());

            int n = ReadInt("Введите количество создаваемых прямоуголньиков: ");
            Polygon[] polygons = new Polygon[n];

            double rad;
            int number;
            do
            {
                for (int i = 0; i < n; i++)
                {
                    number = ReadInt("Введите число сторон: ", 3);
                    rad = ReadInt("Введите радиус: ", 0);
                    polygons[i] = new Polygon(number, rad);

                    Console.WriteLine("Сведения о многоугольнике:");
                    Console.WriteLine(polygon.PolygonData());
                    Console.WriteLine("Для выхода нажмите клавишу ESC");
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
