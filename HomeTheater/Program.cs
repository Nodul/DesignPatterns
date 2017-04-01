using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTest();
        }

        public static void RunTest()
        {
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(new Amplifier(), new DvdPlayer(), new TheaterLights(), new Screen());
            homeTheater.WatchMovie("Star Wars IV");
            homeTheater.EndMovie();
        }
    }
}
