using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Birthday
    {
        string name;
        public DateTime DateOfBirth { get; private set; }

        public Birthday() : this("Иван Иванович", 1970, 1, 1)
        {
            Console.WriteLine("Вызван Birthday без параметров");
        }

        public Birthday(string name, int year = 1970, int month = 1, int day = 1)
        {
            this.name = name;
            DateOfBirth = new DateTime(year, month, day);
            Console.WriteLine("Вызван Birthday с 4 параметрами");
        }

        public string Information {
            get {
                return $"Имя: {name}, День Рождения: {DateOfBirth}";
            }
        }

        public int HowManyDays()
        {
            DateTime nextBirthdayDate;
            if (DateTime.Today.Month > DateOfBirth.Month || DateTime.Today.Day > DateOfBirth.Day)
            {
                nextBirthdayDate = new DateTime(DateTime.Today.Year + 1, DateOfBirth.Month, DateOfBirth.Day);
            }
            else
            {
                nextBirthdayDate = new DateTime(DateTime.Today.Year, DateOfBirth.Month, DateOfBirth.Day);
            }

            return (nextBirthdayDate - DateTime.Today).Days;
        }
    }
}