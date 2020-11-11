using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using SimpleGameFramework.Annotations;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.DesignPatterns
{
    class DefencePoweredDecoratorPropChanged : IDefenceItem, INotifyPropertyChanged
    {
        private IDefenceItem _defenceItem;

        public DefencePoweredDecoratorPropChanged(IDefenceItem defenceItem)
        {
            _defenceItem = defenceItem;
        }

        public int BaseDefence { get; set; }

        public int ImprovedDefence
        {
            get { return _defenceItem.ImprovedDefence / 2; }
            set
            {
                _defenceItem.ImprovedDefence = ImprovedDefence;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get { return _defenceItem.Name; }
            set
            {
                Name = "Powered" + _defenceItem.Name;
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
