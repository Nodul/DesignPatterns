using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Mocha : CondimentDecorator
    {
  

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .20M + _beverage.Cost(); //Here we delegate the task of calculating the cost to beverage and only then we add the condiment cost and return the sum;
        }

        public override string GetDescription()
        {
            return this._beverage.GetDescription() + ", Mocha";
        }
    }
}
