using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    /// <summary>
    /// The better version, with more buttons
    /// </summary>
    class RemoteControl
    {
        Command[] _onCommands;
        Command[] _offCommands;
        Command _undoCommand;

        public RemoteControl()
        {
            _onCommands = new Command[7];
            _offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for(int i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
            _undoCommand = new NoCommand();

        }
        /// <summary>
        /// Can't use property this time, because I need a few parameters
        /// </summary>
        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            //both commands at once, since they are supposed to be connected to 1 device after all
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }
        public void PushOnButton(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }
        public void PushOffButton(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }
        public void PushUndobutton()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\n====== Remote Control ======\n");
            for(int i = 0; i < _onCommands.Length; i++)
            {
                builder.Append(String.Format("[slot {0}] {1}    {2}\n",i,_onCommands[i].GetType(),_offCommands[i].GetType()));
            }

            return builder.ToString();
        }

    }
}
