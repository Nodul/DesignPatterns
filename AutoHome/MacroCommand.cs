using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class MacroCommand : Command
    {
        Command[] _commands;

        public MacroCommand(Command[] commands)
        {
            _commands = commands;
        }
        public void Execute()
        {
            foreach (Command com in _commands) com.Execute();
        }
        public void Undo()
        {
            foreach (Command com in _commands) com.Undo();
        }

    }
}
