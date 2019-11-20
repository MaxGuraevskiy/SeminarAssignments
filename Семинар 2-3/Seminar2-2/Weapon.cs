using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Seminar2_2
{
    class Weapon
    {
        public string Name { get; }
        public int Power { get; }

        public Weapon(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}