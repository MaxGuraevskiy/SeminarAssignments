using System;
using System.Threading;

namespace Seminar2_2
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            Hero hero = new Hero("Эмельрик", 100);
            while (hero.IsAlive)
            {
                int probability = random.Next(0, 100);
                if (probability >= 30)
                {
                    Console.WriteLine($"{hero.Name} продолжает свой тернистый путь");
                }
                else
                {
                    Unit mob = new Mob(random.Next(5, 16), random.Next(0, 10), random.Next(10, 25));
                    Console.WriteLine($"{hero.Name} вступает в схватку с мобом {mob.ToString()}");
                    if (hero.Fight(mob as Mob))
                    {
                        Console.WriteLine($"{hero.Name} вышел из схватки победителем. Осталось {hero.HP} хп");
                    }
                    else
                    {
                        Console.WriteLine($"{hero.Name} трагически погиб");
                        return;
                    }
                }
                Thread.Sleep(1000);
            }
        }
    }
}
