using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachineTest test = new GumballMachineTest();
            test.RunTestV3(new string[] { "Kon-tiki beach", "242" });
            
        }
    }
}
