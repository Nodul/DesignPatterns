using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdAdapter
{
    class Test
    {
        public void RunTest()
        {
            Duck duck = new MallardDuck();         
            Turkey turkey = new WildTurkey();
            Turkey fauxTurkey = new WildTurkey();
            Duck fauxDuck = new MallardDuck();

            TurkeyAdapter tAdapter = new TurkeyAdapter(fauxTurkey);
            DuckAdapter dAdapter = new DuckAdapter(fauxDuck);

            Console.WriteLine("==== Testing duck ====");
            duck.Quack();
            duck.Fly();
            Console.WriteLine("\n==== Testing turkey ====");
            turkey.Gobble();
            turkey.Fly();
            Console.WriteLine("\n==== Testing faux-duck ====");
            testDuck(tAdapter);
            Console.WriteLine("\n==== Testing faux-turkey ====");
            testTurkey(dAdapter);


        }
        void testDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
            
        }
        void testTurkey(Turkey turkey)
        {
            turkey.Gobble();
            turkey.Fly();
        }


    }
}
