using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend Coffee";
        }

        public override decimal Cost()
        {
            return .89M;
        }
    }
}
