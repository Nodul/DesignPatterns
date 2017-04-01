using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    abstract class CondimentDecorator : Beverage
    {
        protected Beverage _beverage;

        //Looks like this isn't needed
        //public abstract new string GetDescription();

        //But I think the class is still needed, because thanks to it we can substitute a Beverage with a Condiment, without anyone really knowing.
        //And a condiment can wrap another condiment and it won't even know whether it's a condiment or just a beverage
    }
}
