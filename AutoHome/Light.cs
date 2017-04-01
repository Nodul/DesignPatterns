using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class Light
    {
        string _name;

        public Light(string name)
        {
            _name = name;
        }

        public void On()
        {
            Console.WriteLine(_name + " light is now ON!");
        }
        public void Off()
        {
            Console.WriteLine(_name + " light is now OFF!");
        }
    }
}
