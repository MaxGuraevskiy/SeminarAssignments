using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            short key;
            try
            {
                byte[] binaryKey = File.ReadAllBytes("key.bin");
                key = BitConverter.ToInt16(binaryKey, 0);
            }
            catch (Exception e)
            {
                key = (short)random.Next(Int16.MinValue, Int16.MaxValue + 1);
            }

            Console.WriteLine("Введите строку для шифрования");
            string input = Console.ReadLine();
            string encrypted = Encrypt(input, key);

            // безопасное использование потоковой записи в файл
            using (StreamWriter streamWriter = new StreamWriter("../../../encrytedData.txt"))
            {
                streamWriter.WriteLine(key);
                streamWriter.WriteLine(encrypted);
                streamWriter.Close();
            }

            // безопасное использование потокового чтения из файла
            using (StreamReader streamReader = new StreamReader("../../../encrytedData.txt"))
            {
                key = Int16.Parse(streamReader.ReadToEnd());
                string str = Encrypt(encrypted, key);
                streamReader.Close();
            }
        }

        private static string Encrypt(string str, short key)
        {
            string result = " ";
            for (int i = 0; i < str.Length; i++)
            {
                result += (char)(str[i] ^ key);
            }

            return result;
        }
    }
}
