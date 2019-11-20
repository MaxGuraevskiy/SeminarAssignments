using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using static Seminar2_2.Program;

namespace Seminar2_2
{
    class MobArmy
    {
        private Mob[] army;

        public MobArmy(int size)
        {
            army = new Mob[size];
            for (int i = 0; i < size; ++i)
            {
                if (random.Next(0, 5) == 0)
                {
                    army[i] = new Boss(random.Next(5, 16), random.Next(0, 10), random.Next(10, 25), random.Next(1, 5)); ;
                }
                else
                {
                    army[i] = new Mob(random.Next(5, 16), random.Next(0, 10), random.Next(10, 25));
                }
            }
        }

        public int Size { get { return army.Length; } }

        public Mob this[int i]
        {
            get
            {
                if(i < 0 || i >= Size)
                {
                    throw new ArgumentException();
                }

                return army[i];
            }
        }

        public bool IsAlive
        {
            get
            {
                int totalHp = 0;
                foreach (Mob mob in army)
                {
                    totalHp += mob.HP;
                }

                //if (totalHp > 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}

                return totalHp > 0;
            }
        }

        
    }
}