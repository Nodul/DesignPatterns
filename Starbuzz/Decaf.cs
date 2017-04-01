using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            this.description = "Decaf Coffee";
        }

        public override decimal Cost()
        {
            return 1.05M;
        }
    }
}
