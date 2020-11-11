using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework
{
    public class Monster : Creature
    {
        public Monster(int damage, string name) : base( name)
        {
            damage = Damage;
            name = Name;
        }
    }
}
