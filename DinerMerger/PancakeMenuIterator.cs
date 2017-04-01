using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class PancakeMenuIterator : Iterator
    {
        ArrayList items;
        int position = 0;

        public PancakeMenuIterator(ArrayList _menuItems)
        {
            items = _menuItems;
            
        }

        public bool HasNext()
        {
            if (position >= items.Count || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            MenuItem item = (MenuItem)items[position];
            position++;
            return item;
        }
    }
}
