using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class NoQuarterState : State
    {
        GumballMachine machine;

        public NoQuarterState(GumballMachine _gumballMachine)
        {
            machine = _gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("Please insert quarter first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter.");
            machine.State = machine.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank turned, but no quarter was inserted.");
        }
    }
}
