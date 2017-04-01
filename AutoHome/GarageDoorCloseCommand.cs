using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class GarageDoorCloseCommand : Command
    {
        GarageDoor _door;

        public GarageDoorCloseCommand(GarageDoor door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Down();
        }

        public void Undo()
        {
            _door.Up();
        }
    }
}
