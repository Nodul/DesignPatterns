using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {

        public Cheese CreateCheese()
        {
            return new ChicaganoCheese();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {

            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new TomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[]  { new Garlic(),new GreenOnion(),new Mushroom(), new BlackPepper() };
        }
    }
}
