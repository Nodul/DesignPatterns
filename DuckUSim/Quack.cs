using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class Quack : QuackBehavior
    {
        void QuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
