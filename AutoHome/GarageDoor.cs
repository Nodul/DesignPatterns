using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class GarageDoor
    {
        string _name;
        public GarageDoor(string name)
        {
            _name = name;
        }

        //Implementation specific methods
        public void Up() { Console.WriteLine(_name+"Garage doors are going UP!"); }

        public void Down() { Console.WriteLine(_name+"Garage doors are going DOWN!"); }

        public void Stop() { Console.WriteLine(_name+"Garage doors have STOPPED!"); }

        public void LightOn() { Console.WriteLine(_name+"Garage doors' LIGHT IS ON"); }

        public void LightOff() { Console.WriteLine(_name+"Garage doors' LIGHT IS OFF"); }
    }
}
