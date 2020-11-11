using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework
{
    public class Hero : Creature
    {
        public Hero(int damage, string name) : base(name)
        {
            damage = Damage;
            name = Name;
        }
    }
}
