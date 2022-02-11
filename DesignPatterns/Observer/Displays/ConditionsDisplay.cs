using DesignPatterns.Observer.Interfaces;

namespace DesignPatterns.Observer.Displays
{
    internal class ConditionsDisplay : IObserver, IDisplayable
    {
        private int _temperature;
        private int _humidity;
        private IObservable _weatherData;

        public ConditionsDisplay(IObservable weatherData)
        {
            _weatherData = weatherData;
            _weatherData.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature} F degrees and {_humidity}% humidity");
        }

        public void Update(int temp, int humidity, int pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }
    }
}
