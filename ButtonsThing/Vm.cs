using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonsThing
{
    using System.Collections.ObjectModel;
    using System.Windows;

    public class Vm
    {
        private readonly ObservableCollection<ButtonInfo> _buttonInfos = new ObservableCollection<ButtonInfo>();
        public Vm()
        {
            _buttonInfos = new ObservableCollection<ButtonInfo>
            {
                new ButtonInfo(new RelayCommand(o => MessageBox.Show("1")), "B1"),
                new ButtonInfo(new RelayCommand(o => MessageBox.Show("2")), "B2"),
                new ButtonInfo(new RelayCommand(o => MessageBox.Show("3")), "B3")
            };
            AddItem= new RelayCommand(o=>Add());
        }
        public ObservableCollection<ButtonInfo> ButtonInfos
        {
            get { return _buttonInfos; }
        }
        public RelayCommand AddItem { get; private set; }
        private void Add()
        {
            int c = ButtonInfos.Count;
            ButtonInfos.Add(new ButtonInfo(new RelayCommand(o => MessageBox.Show(c.ToString())), "B" + c));
        }
    }
}
