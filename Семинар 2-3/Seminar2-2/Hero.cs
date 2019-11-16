using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Seminar2_2
{
    class Hero : Unit
    {
        public int weaponPower;
        public string Name { get; }

        public Hero(string name, int hp) : base(hp)
        {
            Name = name;
            weaponPower = 1;
        }

        public override void Attack(Unit enemy)
        {
            base.Attack(enemy);
            enemy.HP -= weaponPower;
        }

        public bool Fight(Mob mob)
        {
            while (IsAlive && mob.IsAlive)
            {
                Attack(mob);
                mob.Attack(this);
            }

            return IsAlive;
        }
    }
}