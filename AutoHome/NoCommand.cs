using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    /// <summary>
    /// Just an empty class
    /// </summary>
    class NoCommand : Command
    {    
        public void Execute()
        {
            //Console.WriteLine("*BZZZ* Unassigned button");
        }

        public void Undo()
        {
            
        }
    }
}
