using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework
{
    public abstract class WorldObjects : IPosition
    {
        public abstract bool RemoveAble { get; set; }
        public abstract bool LootAble { get; set; }
        public abstract string Name { get; set; }


        public WorldObjects(bool removeAble, bool lootAble, string name)
        {
            RemoveAble = removeAble;
            LootAble = lootAble;
            Name = name;
        }

        
    }
}
