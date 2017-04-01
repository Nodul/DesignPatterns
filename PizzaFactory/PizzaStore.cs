using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public abstract class PizzaStore
    {
       // protected SimplePizzaFactory _factory;

        //public PizzaStore(SimplePizzaFactory factory) { _factory = factory; }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);// _factory.CreatePizza(type); //notice, this isn't a concrete implementation. No "new" operator
           
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
