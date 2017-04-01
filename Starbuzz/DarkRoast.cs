using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.description = "Dark Roast Coffee";
      
        }

        public override decimal Cost()
        {
          
            return .99M;
        }
    }
}
