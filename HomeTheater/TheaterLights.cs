using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTheater
{
    class TheaterLights
    {
        int brightness;
        static readonly int HIGH = 20;
        static readonly int DIM = 10;
        static readonly int OFF = 0; 

        public TheaterLights()
        {
            brightness = 0;
        }

        public void On()
        {
            brightness = HIGH;
            Console.WriteLine("Lights are on, brightly");
        }
        public void Off()
        {
            brightness = OFF;
            Console.WriteLine("Lights are off");
        }
        public void Dim(int power)
        {
            brightness = power;
            Console.WriteLine("Lights are dimmed.");
        }

    }
}
