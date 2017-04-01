using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class WinnerState : State
    {
        GumballMachine machine;

        public WinnerState(GumballMachine _gumballMachine)
        {
            machine = _gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("CONGRATULATIONS!!! A WINNER IS YOU!!! You get 2 gumballs for the price of 1 quarter.");
            machine.ReleaseBall();
            if (machine.Count == 0) machine.State = machine.SoldOutState;
            else
            {
                machine.ReleaseBall();
                if (machine.Count > 0)
                {
                    machine.State = machine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("Whoops! Out of gumballs.");
                    machine.State = machine.SoldOutState;
                }
            }
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
