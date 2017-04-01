using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class ModelDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a model duck!");
        }

        public ModelDuck()
        {
            FlyBehavior = new FlyNoWings();
            QuackBehavior = new Quack();

        }
    }
}
