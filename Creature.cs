using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework
{
    public class Creature : IHeroCreatureFactory
    {
        private int _hitPoints = 100;
        private bool _dead = false;
        private int _damage;
        private string _name;


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int HitPoints
        {
            get => _hitPoints;
            set => _hitPoints = value;
        }

        public bool Dead
        {
            get => _dead;
            set => _dead = value;
        }

        public int Damage
        {
            get => _damage;
        }

        private AttackItem _attackItem { get; set; }
        private DefenceItem _defenceItem { get; set; }
        private WorldObjects WorldObjects { get; set; }

        public Creature(string name)
        {
            Name = name;
        }

        public int Hit(Creature enemy)
        {
            return _damage += _attackItem.CurrentDamage;
        }

        public void Loot(WorldObjects lootWorldObjects)
        {
            if (lootWorldObjects.GetType() == typeof(AttackItem))
            {
                _attackItem = (AttackItem) lootWorldObjects;
            }
            else if (lootWorldObjects.GetType() == typeof(DefenceItem))
            {
                _defenceItem = (DefenceItem) lootWorldObjects;
            }
            else
            {
                lootWorldObjects = (WorldObjects) lootWorldObjects;
            }
        }

        public int RecieveHit(int damageFromAttacker)
        {
            HitPoints = HitPoints - damageFromAttacker;
            if (_hitPoints < 0)
            {
                Dead = true;
            }

            return HitPoints;
        }

    }
}
