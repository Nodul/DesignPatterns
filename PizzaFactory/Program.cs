using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nypizzaStore = new NYStylePizzaStore();
            nypizzaStore.OrderPizza("cheese");
            Console.WriteLine();
            nypizzaStore.OrderPizza("clam");
            Console.WriteLine();
            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();
            chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine();
            chicagoPizzaStore.OrderPizza("veggie");
            Console.WriteLine();
            nypizzaStore.OrderPizza("pepperoni");
            

        }
    }
}
