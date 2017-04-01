using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAdapter
{
    class MallardDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
