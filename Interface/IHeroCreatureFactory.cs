using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.Interface
{
    public interface IHeroCreatureFactory
    {
        string Name { get; }
        int HitPoints { get; }
        bool Dead { get; set; }
        int Damage { get; }

        int Hit(Creature enemy);
        void Loot(WorldObjects lootWorldObjects);
        int RecieveHit(int damageFromAttacker);

        void EquipAttack(IAttackItem a);
        void EquipDefence(IDefenceItem d);
    }
}
