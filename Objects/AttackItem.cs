using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework
{
    public class AttackItem : WorldObjects, IAttackItem
    {
        public int CurrentDamage { get; set; }
        
        public AttackItem(bool removeAble, bool lootAble, string name) : base(removeAble, lootAble, name)
        {
        }
        
        public override bool RemoveAble { get; set; }
        public override bool LootAble { get; set; }
        public override string Name { get; set; }
    }
}
