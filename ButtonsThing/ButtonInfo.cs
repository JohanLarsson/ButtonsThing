using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonsThing
{
    public class ButtonInfo
    {
        public ButtonInfo(RelayCommand command, string text)
        {
            Command = command;
            Text = text;
        }
        public RelayCommand Command { get; private set; }
        public string Text { get; private set; }
    }
}
