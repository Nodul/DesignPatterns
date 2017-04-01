using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] _items)
        {
            items = _items;
        }

        public bool HasNext()
        {
            if (position >= items.Length || items[position] == null)
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
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }
    }
}
