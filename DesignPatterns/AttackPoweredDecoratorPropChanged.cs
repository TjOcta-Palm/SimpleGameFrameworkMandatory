using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SimpleGameFramework.Annotations;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.DesignPatterns
{
    public class AttackPoweredDecoratorPropChanged : IAttackItem, INotifyPropertyChanged
    {
        private IAttackItem _iattackItem;

        public AttackPoweredDecoratorPropChanged(IAttackItem attackItem)
        {
            _iattackItem = attackItem;
        }

        public int BaseDamage { get; set; }

        public int CurrentDamage
        {
            get { return _iattackItem.CurrentDamage * 2; }
            set
            {
                _iattackItem.CurrentDamage = CurrentDamage; 
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _iattackItem.Name; }
            set
            {
                Name = "Powered" + _iattackItem.Name; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
