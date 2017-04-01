using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class HomeTheaterFacade
    {
        //Composition part
        Amplifier amp;
        DvdPlayer dvd;
        TheaterLights lights;
        Screen screen;
        //Tuner tuner;
        //CdPlayer cd;
        //PopcornPopper popper;


        //Facade will be passed  a reference to each component in the subsystem on it's construction
        //then, they will be assinged to the fields above
        public HomeTheaterFacade(Amplifier _amp,
            DvdPlayer _dvd,
            TheaterLights _lights,
            Screen _screen)
        {
            amp = _amp;
            dvd = _dvd;
            lights = _lights;
            screen = _screen;
        }

        //Other methods
        public void WatchMovie(string movie)
        {
            Console.WriteLine("Getting ready to watch movie...");
            lights.Dim(10);
            screen.Down();
            amp.On();
            amp.SetDVD(dvd);
            amp.SetSurroundSound();
            amp.SetVolume(5);
            dvd.On();
            dvd.Play(movie);
        }
        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            lights.On();
            screen.Up();
            amp.Off();
            dvd.Stop();
            dvd.Eject();
            dvd.Off();
        }

    }
}
