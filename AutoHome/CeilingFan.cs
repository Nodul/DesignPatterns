using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class CeilingFan
    {
        public static readonly int HIGH = 3;
        public static readonly int MEDIUM = 2;
        public static readonly int LOW = 1;
        public static readonly int OFF = 0;

        string _name;
        int speed;

        public int Speed
        {
            get { return speed; }
        }

        public CeilingFan(string name)
        {
            _name = name;
            speed = OFF;
        }

        public void High()
        {
            speed = HIGH;
            Console.WriteLine(_name+" ceiling fan is rotating at HIGH speed now.");
        }
        public void Medium()
        {
            speed = MEDIUM;
            Console.WriteLine(_name + " ceiling fan is rotating at MEDIUM speed now.");
        }
        public void Low()
        {
            speed = LOW;
            Console.WriteLine(_name + " ceiling fan is rotating at LOW speed now.");
        }
        public void Off()
        {
            speed = OFF;
            Console.WriteLine(_name + " ceiling fan is OFF now.");
        }
        

    }
}
