using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    /// <summary>
    /// Exactly the same as LightOfCommand, just execute contains a _light.Off() this time
    /// </summary>
    class LightOffCommand : Command
    {
        Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
