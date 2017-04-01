using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrista
{
    abstract class CaffeineBeverage
    {
        internal void PrepareRecipe()
        {
            Console.WriteLine("==== Preparing {0} recipe ====",this.GetType().ToString());
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
            Console.WriteLine();
            
        }
        internal abstract void Brew();

        internal abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling Water");
           
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        internal virtual bool CustomerWantsCondiments()
        {
            return true; //This is a hook, because the subclass can, but doesn't have to, override this
        }
    }
}
