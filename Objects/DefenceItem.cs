using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework
{
    public class DefenceItem : WorldObjects, IDefenceItem
    {
        public int BaseDefence { get; set; }
        public int ImprovedDefence { get; set; }


        public DefenceItem(bool removeAble, bool lootAble, string name) : base(removeAble, lootAble, name)
        {
        }

        public override bool RemoveAble { get; set; }
        public override bool LootAble { get; set; }
        public override string Name { get; set; }
    }
}
