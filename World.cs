using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGameFramework
{
    class World
    {
        
        public List<WorldObjects> worldObjects;
        public Position worldBorderPosition;


        public World(Position worldSize)
        {
            worldBorderPosition = worldSize;
            worldObjects = new List<WorldObjects>();
        }


        public void GetAllItems()
        {
            var weapons = worldObjects.Select(i => i.GetType()).Where(d => d == typeof(AttackItem));
        }
    }
}