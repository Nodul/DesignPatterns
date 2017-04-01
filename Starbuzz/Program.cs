using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage bev1 = new Expresso();
            Console.WriteLine(bev1.GetDescription()+", $" + bev1.Cost());

            Beverage bev2 = new DarkRoast();
            bev2 = new Mocha(bev2);
            bev2 = new Mocha(bev2);
            bev2 = new Whip(bev2);
            Console.WriteLine(bev2.GetDescription() + ", $" + bev2.Cost());

            Beverage bev3 = new HouseBlend();
            bev3 = new Soy(bev3);
            bev3 = new Mocha(bev3);
            bev3 = new Whip(bev3);
            Console.WriteLine(bev3.GetDescription()+", $"+bev3.Cost());

        
        }
    }
}
