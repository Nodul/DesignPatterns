using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class HasQuarterState : State
    {
        GumballMachine machine;
        Random randomWinner = new Random(System.Environment.TickCount);

        public HasQuarterState(GumballMachine _gumballMachine)
        {
            machine = _gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed"); //Inappropiate action
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            machine.State = machine.NoQuarterState;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter.");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Crank turned...");
            int winner = randomWinner.Next(11); //11 since the upper bound is exclusive
            if(winner == 0 && machine.Count > 1)
            {
                machine.State = machine.WinnerState;
            }
            else
            {
                machine.State = machine.SoldState;
            }           
            //Dispense(); //Gumball machines does the dispensing now
        }
    }
}
