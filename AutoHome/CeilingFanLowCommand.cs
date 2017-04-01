using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class CeilingFanLowCommand : Command
    {

        CeilingFan _fan;
        int prevSpeed;

        public CeilingFanLowCommand(CeilingFan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            prevSpeed = _fan.Speed;
            _fan.Low();
        }

        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH) _fan.High();
            else if (prevSpeed == CeilingFan.MEDIUM) _fan.Medium();
            else if (prevSpeed == CeilingFan.LOW) _fan.Low();
            else if (prevSpeed == CeilingFan.OFF) _fan.Off();

        }
    }
}
