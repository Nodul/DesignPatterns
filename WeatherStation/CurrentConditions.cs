using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class CurrentConditions : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditions(Subject _weatherData)
        {
            //Initial registering with WeatherData
            weatherData = _weatherData;
            weatherData.RegisterObserver(this);
        }


        public void Display()
        {
            Console.WriteLine("Current conditions: {0} Celsius, {1}% humidity.",temperature,humidity);
        }

        public void Update(float t, float h, float p)
        {
            this.temperature = t;
            this.humidity = h;
            Display();
        }
    }
}
