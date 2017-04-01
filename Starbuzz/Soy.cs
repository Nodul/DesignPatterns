using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Soy : CondimentDecorator
    {
       

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .15M + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
    }
}
