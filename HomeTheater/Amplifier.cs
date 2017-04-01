using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class Amplifier
    {
        DvdPlayer myDvd;
        int volume;
        bool surround;

        public Amplifier()
        {
            volume = 0;
            surround = false;
        }

        public void On()
        {
            Console.WriteLine("The amplifier is now on");
        }
        public void Off()
        {
            Console.WriteLine("The amplifier is now off");
        }
        public void SetDVD(DvdPlayer _dvd)
        {
            myDvd = _dvd;
            Console.WriteLine("The amplifier is now connected to a DVD Player");
        }
        public void SetSurroundSound()
        {
            surround = true;
            Console.WriteLine("The amplifier has enabled Surround Sound");
        }
        public void SetVolume(int _vol)
        {
            volume = _vol;
            Console.WriteLine("Amplifier volume is now set to {0}",volume);
        }

    }
}
