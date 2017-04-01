using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrista
{
    class Tea : CaffeineBeverage
    {

        internal override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Adding lemon.");
        }
    }
}
