using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using static Seminar2_2.Program;

namespace Seminar2_2
{
    class Hero : Unit
    {
        public string Name { get; }
        public Weapon Weapon { get; }

        public Hero(string name, int hp) : base(hp)
        {
            Name = name;
            Weapon = new Weapon("Палка-копалка", 1);
        }

        public Hero(string name, int hp, Weapon weapon) : base(hp)
        {
            Name = name;
            Weapon = weapon;
        }

        public override void Attack(Unit enemy)
        {
            base.Attack(enemy);
            enemy.HP -= Weapon.Power;
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

        public bool Fight(MobArmy mobArmy)
        {
            while (IsAlive && mobArmy.IsAlive)
            {
                int randomMobIndex = random.Next(mobArmy.Size);
                Mob mobInArmy = mobArmy[randomMobIndex];
                if (mobInArmy.IsAlive)
                {
                    Attack(mobInArmy);
                    mobInArmy.Attack(this);
                }
            }

            return IsAlive;
        }
    }
}