using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.Objects
{
    class WorldItems : WorldObjects
    {
        public WorldItems(bool removeAble, bool lootAble, string name) : base(removeAble, lootAble, name)
        {
        }

        public override bool RemoveAble { get; set; }
        public override bool LootAble { get; set; }
        public override string Name { get; set; }
    }
}
