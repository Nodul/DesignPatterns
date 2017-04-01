using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class FlyNoWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I cannot fly!");
        }
    }
}
