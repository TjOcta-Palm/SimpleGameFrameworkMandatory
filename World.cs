using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleGameFramework
{
    class World
    {
        
        private static World _instance;
        public List<WorldObjects> worldObjects;
        public Position worldBorderPosition;

        private World()
        {
        }

        public World(Position worldSize)
        {
            worldBorderPosition = worldSize;
            worldObjects = new List<WorldObjects>();
        }

        public static World WorldInstance => _instance ?? (_instance = new World());

        public void GetAllItems()
        {
            var weapons = worldObjects.Select(i => i.Name).Where(d => d.GetType() == typeof(AttackItem));
        }
    }
}