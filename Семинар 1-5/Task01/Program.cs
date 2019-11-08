using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static Random random = new Random();
        const int ArraySize = 5;

        static int[] createArray(int size)
        {
            int[] a = new int[size];

            for (int i = 0; i < size; ++i)
            {
                a[i] = random.Next(10, 51); // [10; 51) <-> [10; 50]}
            }

            return a;
        }

        static void OwnResize(int[] array, int newSize)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = array[i] * 2;
            }

            int[] newArray = new int[array.Length + newSize];
            Array.Copy(array, newArray, array.Length);

            array = newArray;
        }

        static void Main(string[] args)
        {
            int[] a = createArray(ArraySize);
            Console.WriteLine("Array A:");
            foreach (int number in a)
            {
                Console.WriteLine(number);
            }

            int[] b = createArray(ArraySize);
            Console.WriteLine("Array B:");
            foreach (int number in b)
            {
                Console.WriteLine(number);
            }

            int countEvent = 0;
            List<int> evenNumbers = new List<int>();
            foreach (int number in b)
            {
                if (number % 2 == 0)
                {
                    ++countEvent;
                    evenNumbers.Add(number);
                }
            }

            Array.Resize(ref a, a.Length + countEvent);
            Array.Copy(evenNumbers.ToArray(), 0, a, ArraySize, countEvent);

            Console.WriteLine("Array A:");
            foreach (int number in a)
            {
                Console.WriteLine(number);
            }
        }
    }
}