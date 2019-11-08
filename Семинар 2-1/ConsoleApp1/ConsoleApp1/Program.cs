using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Birthday myBirthday = new Birthday("Иван", 1987, 4, 21);
            //Console.WriteLine(myBirthday.Information);
            //Console.WriteLine($"До след. ДР осталось {myBirthday.HowManyDays()} дней");

            Birthday anotherBirthday = new Birthday();
            Console.WriteLine(anotherBirthday.Information);
            Console.WriteLine($"До след. ДР осталось {anotherBirthday.HowManyDays()} дней");
        }
    }
}
