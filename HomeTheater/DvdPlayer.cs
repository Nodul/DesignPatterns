using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class DvdPlayer
    {
        string movie;

        public DvdPlayer()
        {
            movie = "";
        }

        public void On()
        {
            Console.WriteLine("DVD Player is now on");
        }
        public void Off()
        {
            Console.WriteLine("DVD Player is now off");
        }
        public void Eject()
        {
            movie = "";
            Console.WriteLine("DVD Player has ejected the DVD disc");
        }
        public void Play(string _movie)
        {
            movie = _movie;
            Console.WriteLine("DVD Player has started playing \"{0}\"",movie);
        }
        public void Stop()
        {
            Console.WriteLine("DVD Player has stopped playing {0}",movie);
        }
    }
}
