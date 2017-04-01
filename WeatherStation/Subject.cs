using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    interface Subject
    {
        void RegisterObserver(Observer obs);
        void RemoveObserver(Observer obs);
        void NotifyObservers();
    }
}
