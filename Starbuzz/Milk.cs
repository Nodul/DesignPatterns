﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Milk : CondimentDecorator
    {
      

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override decimal Cost()
        {
            return .10M + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage + ", Steamed Milk";
        }
    }
}
