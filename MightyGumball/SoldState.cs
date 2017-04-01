using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class SoldState : State
    {
        GumballMachine machine;

        public SoldState(GumballMachine _gumballMachine)
        {
            machine = _gumballMachine;
        }

        public void Dispense()
        {
            machine.ReleaseBall();
            if (machine.Count > 0)
            {
                machine.State = machine.NoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                machine.State = machine.SoldOutState;
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you have already turned the crank.");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, the machine is already dispensing a gumball.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice will not dispense another gumball.");
        }
    }
}
