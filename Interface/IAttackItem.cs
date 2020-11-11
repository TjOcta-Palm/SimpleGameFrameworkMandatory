using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.Interface
{
    public interface IAttackItem
    {
        public int CurrentDamage { get; set; }
        public string Name { get; set; }
    }
}
