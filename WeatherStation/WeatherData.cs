using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temp = 32f;
        private float humidity = 52f;
        private float pressure = 1013f;

        public float Temperature
        {
            get { return temp; }
            set { temp = value; }
        }

        public float Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        public float Pressure
        {
            get { return pressure; }//kPa
            set { pressure = value; }
        }


        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer obs)
        {
            observers.Add(obs);
        }
        public void RemoveObserver(Observer obs)
        {
            observers.Remove(obs);
        }
        public void NotifyObservers()
        {
            for(int i = 0; i < observers.Count; i++)
            {
                observers[i].Update(Temperature, Humidity, Pressure);
                

            }
        }
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(float _temp, float _humi, float _press)
        {
            Temperature = _temp;
            Humidity = _humi;
            Pressure = _press;
            MeasurementsChanged();
        }



    }
}
