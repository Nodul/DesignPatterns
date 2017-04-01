using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    class ChicagoStylePizzaStore : PizzaStore
    {

        protected override Pizza CreatePizza(string type)
        {

            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "Chicago Style Cheese Pizza";
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "Chicago Style Veggie Pizza";
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "Chicago Style Clam Pizza";
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "Chicago Style Pepperoni Pizza";
            }

            return pizza;
        }
    }
}
