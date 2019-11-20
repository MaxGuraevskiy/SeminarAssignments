using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Seminar2_2
{
    abstract class Unit
    {
        private readonly int maxHp;
        private int hp;
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                if (value > maxHp)
                {
                    hp = maxHp;
                }
                else if (value > 0)
                {
                    hp = value;
                }
                else { hp = 0; }
            }
        }

        // автореализуемое свойство, поле создается неявно
        public int XP { get; protected set; }
        ////явно объявленное поле и свойство
        //private int xp;
        //public int XP
        //{
        //    get
        //    {
        //        return xp;
        //    }
        //    protected set
        //    {
        //        xp = value;
        //    }
        //}

        public int Strength { get; protected set; }

        public Unit() : this(100)
        {
            //hp = 100;
            //maxHp = 100;
            //XP = 0;
        }

        public Unit(int hp) : this(hp, hp)
        {
            //this.hp = hp;
            //maxHp = hp;
            //XP = 0;
        }

        public Unit(int hp, int maxHp)
        {
            this.hp = hp;
            this.maxHp = maxHp;
            XP = 0;
            Strength = 10;
        }

        public virtual void Attack(Unit enemy)
        {
            enemy.HP -= Strength;
        }

        public bool IsAlive
        {
            get { return hp > 0; }
        }
    }
}