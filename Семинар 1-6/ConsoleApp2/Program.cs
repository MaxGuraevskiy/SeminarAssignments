using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("Введите число N");
            } while (!Int32.TryParse(Console.ReadLine(), out n));

            int[] array = new int[
                random.Next(n / 2 + 1, 2 * n + 1)
                ];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = random.Next(-n, n + 1);
                Console.Write(array[i] + " ");
            }

            try
            {
                File.WriteAllText("../../../intNum.txt", String.Join(" ", array));

                List<byte> bytes = new List<byte>();
                foreach (int num in array)
                {
                    bytes.AddRange(BitConverter.GetBytes(num));
                }
                File.WriteAllBytes("../../../intNum.bin", bytes.ToArray());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
