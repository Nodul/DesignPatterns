using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class SimpleRemoteControl
    {
        Command slot;

        public SimpleRemoteControl() { }

        public Command Command
        {
            set { slot = value; }
        }

        public void ButtonPress()
        {
            slot.Execute();
        }
    }
}
