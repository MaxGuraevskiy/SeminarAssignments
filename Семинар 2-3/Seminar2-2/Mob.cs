using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Seminar2_2
{
    class Mob : Unit
    {
        public Mob(int hp, int xp, int strength) : base(hp)
        {
            XP = xp;
            Strength = strength;
        }

        public override string ToString()
        {
            return $"Моб с со здоровьем {HP} хп и силой атаки {Strength} ед. урона";
        }
    }
}