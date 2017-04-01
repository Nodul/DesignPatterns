using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    /// <summary>
    /// This works a little difference than Pancake Menu, since Mel wants to be 100% there is a limit to how many items there are and he doesn't have to cast object
    /// </summary>
    class DinerMenu
    {
        static readonly int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuItem[] menuItems;
        //public MenuItem[] MenuItems { get { return menuItems; } } //We don't need this because it exposes our internal implementaion!

        public Iterator CreateIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            AddItem("Vegetarian BLT","(Fakin') Bacon with lettuce & tomato on whole wheat",true, 2.99m);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99m);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29m);
            AddItem("Hotdog", "Hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05m);
        }

        public void AddItem(string name, string description,bool vegetarian,decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS) Console.WriteLine("Can't add item to menu: Menu is full");
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

    }
}
