using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class GumballMachineTest
    {
        /// <summary>
        /// Test with GumballMonitor. First argument should be location, second an int of gumballs
        /// </summary>
        public void RunTestV3(string[] args)
        {
            int count = 0;
            if(args.Length < 2)
            {
                Console.WriteLine("GumballMachine <name> <inventory>");
                Environment.Exit(1);
            }

            count = Int32.Parse(args[1]);



            GumballMachine machine = new GumballMachine(args[0], count);

            GumballMonitor monitor = new GumballMonitor(machine);

            Console.WriteLine(machine.ToString());

            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine.ToString());

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine.ToString());
            monitor.Report();
        }
        /// <summary>
        /// Test with WinnerState implemented
        /// </summary>
        public void RunTestV2()
        {
            GumballMachine machine = new GumballMachine("Test2",5);

            Console.WriteLine(machine.ToString());

            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine.ToString());

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine.ToString());

        }
        /// <summary>
        /// Simple test
        /// </summary>
        public void RunTestV1()
        {
            GumballMachine machine = new GumballMachine("Test1",5);
           // Console.WriteLine(machine.ToString());
            //machine.Refill(10);
            Console.WriteLine(machine.ToString());

            machine.InsertQuarter();
            machine.EjectQuarter();
            machine.TurnCrank();

            Console.WriteLine(machine.ToString());

            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.EjectQuarter();

            Console.WriteLine(machine.ToString());

            machine.InsertQuarter();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.InsertQuarter();
            machine.TurnCrank();
            machine.EjectQuarter();

            Console.WriteLine(machine.ToString());

        }
        
        


    }
}
