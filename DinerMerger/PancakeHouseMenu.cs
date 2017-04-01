using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DinerMerger
{
    /// <summary>
    /// This is simpler than Mel's menu and there isn't a limit;
    /// </summary>
    class PancakeHouseMenu
    {
        ArrayList menuItems;
        //public ArrayList MenuItems { get { return menuItems; } }

        public Iterator CreateIterator()
        {
            return new PancakeMenuIterator(menuItems);
        }

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs and toast",true,2.99m);
            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs and sausage", false, 2.99m);
            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries", true, 3.49m);
            AddItem("Waffles", "Waffles with your choice of blueberries or strawberries", true, 3.59m);

        }

        public void AddItem(string name, string description, bool vegetarian, decimal price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

    } 
}
