using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private readonly WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        //public void Update(float temperature, float humidity, float pressure)
        //{
        //    this._temperature = temperature;
        //    this._humidity = humidity;
        //    Display();
        //}
        public void Update()
        {
            this._temperature = _weatherData.GetTemperature();
            this._humidity = _weatherData.GetHumidity();
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }
    }
}
