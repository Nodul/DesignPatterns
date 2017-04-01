using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHome
{
    class Program //Client [creates concrete command + sets it's receiver]
    {
        static void Main(string[] args)
        {
            RemoteLoader loader = new RemoteLoader();
            loader.RunPartyModeTest();
            
            
        }

        

    }
}
