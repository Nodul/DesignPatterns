using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class GumballMonitor
    {
        GumballMachine machine;

        public GumballMonitor(GumballMachine _gumballMachine)
        {
            machine = _gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball machine: {0}",machine.Location);
            Console.WriteLine("Current inventory: {0} gumballs", machine.Count);
            Console.WriteLine("Current state: {0}", machine.State.ToString());
        }
    }
}
