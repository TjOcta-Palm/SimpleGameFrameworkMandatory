using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework
{
    public static class HeroCreatureFactory
    {   private static string creatureDecider = "";
        private static Random random = new Random();
        public static IHeroCreatureFactory Create(string creaturPicker)
        {
            creatureDecider = creaturPicker;
            if (creatureDecider == "Hero")
            {
                return new Hero(random.Next(5),"DefaultHero");
            }
            else if (creatureDecider == "Monster")
            {
                return new Monster(random.Next(1,20), "Monster" );
            }
            else
            {
                throw new NotImplementedException("Type either Hero og Monster");
            }
        }
    }
}
