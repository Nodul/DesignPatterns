using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I\'m a real Mallard duck");
        }
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();

        }
        
    }
}
