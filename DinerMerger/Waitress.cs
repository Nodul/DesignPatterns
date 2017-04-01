using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class Waitress
    {
        PancakeHouseMenu pancakeHouseMenu; 
        DinerMenu dinerMenu;


        public Waitress(PancakeHouseMenu _pancakeHouseMenu,DinerMenu _dinerMenu)
        {
            pancakeHouseMenu = _pancakeHouseMenu;
            dinerMenu = _dinerMenu;
        }

        /// <summary>
        /// Prints every item on the menu
        /// </summary>
        public void PrintMenu()
        {
            //Idea 1, just use a loop for each menu
            #region //idea 1 - Commented Out
            /*
            Console.WriteLine("==== Printing breakfast menu ====");
            for(int i = 0; i < breakfastItems.Count; i++)
            {
                MenuItem menuItem = (MenuItem)breakfastItems[i];
                Console.WriteLine("{0} ${1} - {2}",menuItem.Name, menuItem.Price,menuItem.Description);
            }
            Console.WriteLine("\n==== Printing lunch menu ====");
            for (int i = 0; i < lunchItems.Length; i++)
            {
                MenuItem menuItem = lunchItems[i];
                if(lunchItems[i] != null)
                Console.WriteLine("{0} ${1} - {2}", menuItem.Name, menuItem.Price, menuItem.Description);
            }
            */
            #endregion
            //Idea 2, Iterator design pattern
            #region //Idea 2
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            Iterator dinerIterator = dinerMenu.CreateIterator();
            Console.WriteLine("==== Breakfast Menu ====");
            PrintMenu(pancakeIterator);
            Console.WriteLine("\n==== Lunch Menu ====");
            PrintMenu(dinerIterator);
            #endregion

        }
        void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine("{0} ${1} -- {2}",menuItem.Name,menuItem.Price,menuItem.Description);
            }
        }
        /// <summary>
        /// Prints just breakfast items
        /// </summary>
        public void PrintBreakfastMenu()
        {

        }
        /// <summary>
        /// Prints just lunch items
        /// </summary>
        public void PrintLunchMenu()
        {

        }
        /// <summary>
        /// Prinst all vegetarian menu items
        /// </summary>
        public void PrintVegetarianMenu()
        {

        }
        /// <summary>
        /// Given the item name, returs true if the menu item is vegetarian, false if it isn't
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsItemVegetarian(string name)
        {
            throw new NotImplementedException();
        }



    }
}
