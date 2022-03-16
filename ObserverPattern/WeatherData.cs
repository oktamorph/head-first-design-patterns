namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
        public void NotifyObservers()
        {
            foreach(IObserver observer in _observers)
            {
                // observer.Update(_temperature, _humidity, _pressure);
                observer.Update();
            }
        }
        public void MeasurementChanged()
        {
            NotifyObservers();
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementChanged();
        }
        public float GetTemperature()
        {
            return this._temperature;
        }
        public float GetHumidity()
        {
            return this._humidity;
        }
        public float GetPressure()
        {
            return this._pressure;
        }
    }
}
