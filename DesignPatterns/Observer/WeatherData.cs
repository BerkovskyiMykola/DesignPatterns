using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer
{
    internal class WeatherData : IObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        private int _temperature;
        private int _humidity;
        private int _pressure;

        public int GetTemperature() => new Random().Next(-100, 100);

        public int GetHumidity() => new Random().Next(0, 100);

        public int GetPressure() => new Random().Next(0, 100);

        public void AddObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            _temperature = GetTemperature();
            _humidity = GetHumidity();
            _pressure = GetPressure();

            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var o in _observers)
            {
                o.Update(_temperature, _humidity, _pressure);
            }
        }
    }
}
