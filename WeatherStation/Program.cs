using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData wData = new WeatherData();

            CurrentConditions curDisplay = new CurrentConditions(wData);
            //StatisticsDisplay
            //ForecastDisplay
            curDisplay.Display();
            wData.SetMeasurements(50, 30, 1042);
            wData.SetMeasurements(20, 50, 1000);

        }
    }
}
