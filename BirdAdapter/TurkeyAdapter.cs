using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAdapter
{
    /// <summary>
    /// We want to adapt a Turkey into a Duck. Basically this maps Duck functionality to Turkey functionality
    /// </summary>
    class TurkeyAdapter : Duck
    {
        Turkey _turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            _turkey = turkey;
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
        public void Fly()
        {
            //Repeated 5 times, because turkey fly shorter distances, so theyhave to repeat this action
            for(int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }

    }
}
