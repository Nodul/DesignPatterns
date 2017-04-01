using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Expresso : Beverage
    {
        public Expresso()
        {
            this.description = "Expresso";
        
        }

        public override decimal Cost()
        {
            return 1.99M; //We don't care about condiments here.
        }
    }
}
