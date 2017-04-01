using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class GarageDoorOpenCommand : Command
    {
        GarageDoor _door;



        public GarageDoorOpenCommand(GarageDoor door)
        {
            _door = door;
        }

        public void Execute()
        {
            _door.Up();   
        }

        public void Undo()
        {
            _door.Down();
        }



    }
}
