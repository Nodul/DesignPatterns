using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAdapter
{
    class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying! A bit...");          
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble!");
        }
    }
}
