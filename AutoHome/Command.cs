using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    public interface Command
    {
        void Execute();
        void Undo();
    }
}
