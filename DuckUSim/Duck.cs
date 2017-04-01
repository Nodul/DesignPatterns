using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    public abstract class Duck
    {
        FlyBehavior flyBehavior;
        QuackBehavior quackBehavior;

        public FlyBehavior FlyBehavior
        {
            get { return flyBehavior; }
            set { flyBehavior = value; }
        }

        public QuackBehavior QuackBehavior
        {
            get { return quackBehavior; }
            set { quackBehavior = value; }
        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

    }
}
