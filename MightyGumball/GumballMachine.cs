using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;
        string location;

        public State SoldOutState { get { return soldOutState; } }
        public State NoQuarterState { get { return noQuarterState; } }
        public State HasQuarterState { get { return hasQuarterState; } }
        public State SoldState { get { return soldState; } }
        public State WinnerState { get { return winnerState; } }
        public string Location { get { return location; } }

        State state; //current state
        int count = 0; //number of gumballs in the machine
        public int Count { get { return count; } }

        public State State
            {
             get{ return state; }
             set { state = value; }
            }

        public GumballMachine(string _location, int _gumballCount)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            location = _location;
            count = _gumballCount;
            if (count > 0) state = noQuarterState;
            else state = soldOutState;
        }

        //Actions
        public void InsertQuarter()
        {
            state.InsertQuarter();
        }
        public void EjectQuarter()
        {
            state.EjectQuarter();
        }
        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense(); //We don't need the Dispense() in GumballMAchine class, it's in states now
        }
        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot..."); //Helper method
            if (count != 0) count--;
        }
        public void Refill(int _count)
        {
            count += _count;
            state = noQuarterState; //Note this actually might be wrong, since someone might have put a quarter inside. If this is the case, the operator who refills the machine will give back the quarter[if the customer is still around].
            Console.WriteLine("Refilled gumball machine, it now contains {0} gumballs",count);
        }
        public override string ToString()
        {
            return string.Format("**Mighty GumballTM machine**\nholds {0} gumballs\nState: {1}\n",count,state);
        }
    }
}
