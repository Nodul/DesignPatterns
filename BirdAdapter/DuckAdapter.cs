using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAdapter
{
    class DuckAdapter : Turkey
    {
        Duck _duck;
        Random rnd;

        public DuckAdapter(Duck duck)
        {
            _duck = duck;
            rnd = new Random();
        }

        
        public void Fly()
        {
            //Hmm, how to shorten the distance?
            //Change Fly() to actually return a string which you can shorten?
            //Add here a new WriteLine("Puff... Puff... Need to rest from flying!*wink**wink*");
            //The authors add a random number to check how often will it fly. [handwaived as an average out of 5 times]

            if(rnd.Next(5) == 0) _duck.Fly();

        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}
