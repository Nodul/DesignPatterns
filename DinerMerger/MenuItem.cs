using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class MenuItem
    {
        string name;
        string description;
        bool vegetarian;
        decimal price;

        public string Name { get { return name; } }
        public string Description { get { return description; } }
        public bool Vegetarian { get { return vegetarian; } }
        public decimal Price { get { return price; } }

        public MenuItem(string _name,
            string _description,
            bool _vegetarian,
            decimal _price)
        {
            name = _name;
            description = _description;
            vegetarian = _vegetarian;
            price = _price;
        }
        


    }
}
