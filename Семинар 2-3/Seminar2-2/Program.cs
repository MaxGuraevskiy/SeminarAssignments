using System;
using System.Threading;

namespace Seminar2_2
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            Hero hero = new Hero("Эмельрик", 100);
            Console.WriteLine((hero as Hero)?.IsAlive);


            while (hero.IsAlive)
            {
                int probability = random.Next(0, 100);
                if (probability >= 30)
                {
                    Console.WriteLine($"{hero.Name} продолжает свой тернистый путь");
                }
                else if (probability >= 10)
                {
                    Unit mob = new Mob(random.Next(5, 16), random.Next(0, 10), random.Next(10, 25));
                    Unit castMob = mob as Hero;
                    Console.WriteLine($"{hero.Name} вступает в схватку с мобом {castMob?.ToString()}");

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
                else
                {
                    MobArmy army = new MobArmy(random.Next(2, 5));
                    if (hero.Fight(army))
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
