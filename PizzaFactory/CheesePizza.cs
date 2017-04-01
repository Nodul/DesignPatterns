using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    class CheesePizza : Pizza
    {


        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            base.Prepare();
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
        }
    }
}
