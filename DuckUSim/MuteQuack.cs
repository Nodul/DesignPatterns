using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("*Silence*");
        }
    }
}
