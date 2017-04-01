using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public abstract class Pizza
    {
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clams;

        protected List<string> toppings = new List<string>();
        //List<To>
        public PizzaIngredientFactory _ingredientFactory;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing "+name);
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 250 C.");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices.");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }
    }
}
