using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string textPath = "../../../intNum.txt";
            const string binPath = "../../../intNum.bin";

            if (!File.Exists(textPath))
            {
                return;
            }

            string text = File.ReadAllText(textPath);
            string[] allNumbers = text.Split(' ');
            Console.WriteLine(text + Environment.NewLine);

            foreach (string num in allNumbers)
            {
                Console.WriteLine(num);
            }

            byte[] bytes = File.ReadAllBytes(binPath);
            
            for (int i = 0; i < bytes.Length / 4; i++)
            {
                Console.Write(BitConverter.ToInt32(bytes, 4*i) + " ");
            }
        }
    }
}
