using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        /// <summary>
        /// Beverage GetDescription;
        /// </summary>
        /// <returns></returns>
        public virtual string GetDescription()
        {
            return this.description;
        }
        //public string Description {get {return description; } } NOT a property this time, since we need to reimplement it in Decorators

        public abstract decimal Cost();



    }
}
