using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMerger
{
    interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}
