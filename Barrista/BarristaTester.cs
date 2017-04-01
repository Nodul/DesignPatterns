using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrista
{
    class BarristaTester
    {


        public void RunFirstTest()
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            tea.PrepareRecipe();
            coffee.PrepareRecipe();
        }
    }
}
