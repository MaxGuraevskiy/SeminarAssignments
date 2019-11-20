using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Seminar2_2
{
    class Boss : Mob
    {
        public int Level { get; }

        public Boss(int hp, int xp, int strength, int level) : base(hp, xp, strength)
        {
            Level = level;
        }

        public override void Attack(Unit enemy)
        {
            enemy.HP -= Strength * Level;
        }
    }
}