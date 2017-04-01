using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    /// <summary>
    /// Test class for testing ducks
    /// </summary>
    class MiniDuckSimulator
    {
        public static void RunTest()
        {
            Console.WriteLine("Testing mallard duck: ");
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Console.WriteLine("\nTesting model duck [+rocket power]");
            Duck model = new ModelDuck();
            model.PerformQuack();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();          

    }
     
    }
}
