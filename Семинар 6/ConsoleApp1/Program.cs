using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void DirectoryOverview(string path, int level, List<string> deletedDirs)
        {
            var dirs = Directory.GetDirectories(path);

            foreach (var dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dir} Attributes: {dirInfo.Attributes}" +
                    $"Created: {dirInfo.CreationTime}" +
                    $"Last updated: {dirInfo.LastWriteTime}");

                if (level > 0)
                {
                    DirectoryOverview(dir, level - 1, deletedDirs);
                }

                if (dirInfo.GetFiles().Length + dirInfo.GetDirectories().Length == 0)
                {
                    deletedDirs.Add(dirInfo.FullName);
                    dirInfo.Delete();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к директории");
            string path;
            do
            {
                path = Console.ReadLine();
            } while (!new DirectoryInfo(path).Exists);

            int level = 0;
            do
            {
                Console.WriteLine("Введите максимальный уровень вложенности директорий");
            } while (!Int32.TryParse(Console.ReadLine(), out level));

            List<string> deletedDirs = new List<string>();

            try
            {
                DirectoryOverview(path, level, deletedDirs);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"Удаленные директории:\n" +
                   $"{String.Join("\n", deletedDirs.ToArray())}");
            }
        }
    }
}
