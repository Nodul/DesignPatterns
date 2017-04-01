using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class SoldOutState : State
    {
        GumballMachine machine;

        public SoldOutState(GumballMachine _gumballMachine)
        {
            machine = _gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Cannot insert a quarter, the machine is sold out.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank turned, but there are no more gumballs.");
        }
    }
}
