using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrista
{
    class Coffee: CaffeineBeverage
    {


        internal override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        internal override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk.");
        }

        internal override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();
            if (answer.ToLowerInvariant().StartsWith("y")) return true;
            else return false;

        }
        string GetUserInput()
        {
            string answer = null;

            Console.Write("Would you like milk and sugar with your coffee? [y/n] ");

            try
            {
                answer = Console.ReadLine();
            }
            catch (System.IO.IOException)
            {
                Console.WriteLine("An IO error has occured while trying to read your answer.");
            }

            if (answer == null) return "no";
            return answer;
        }
    }
}
