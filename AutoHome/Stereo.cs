using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class Stereo
    {
        string _name;

        public Stereo(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine(_name+" stereo is now ON!");
        }

        public void Off()
        {
            Console.WriteLine(_name + " stereo is now OFF!");
        }

        public void SetCD()
        {
            Console.WriteLine(_name + " stereo is now SET TO CD!");
        }
        public void SetDVD()
        {
            Console.WriteLine(_name + " stereo is now SET TO DVD!");
        }
        public void SetRadio()
        {
            Console.WriteLine(_name + " stereo is now SET TO RADIO!");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine(_name + " stereo is now at VOLUME " + volume);
        }


    }
}
