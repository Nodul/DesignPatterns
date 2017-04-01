using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckUSim
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MiniDuckSimulator.RunTest();

            Console.WriteLine(FormatRGB(100,255,0));
        }

        static string FormatRGB(int r, int g, int b)
        {
            string result = "";
            result += String.Format("{0:x}", r);
            result += String.Format("{0:x}", g);
            result += String.Format("{0:x}", b);

            return result;
        }
     
    }
}
