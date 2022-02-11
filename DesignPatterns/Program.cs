using DesignPatterns.Observer;
using DesignPatterns.Observer.Displays;
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Ducks;

Duck mallard = new Mallard();
mallard.Display();
mallard.Quack();
mallard.Fly();

Duck modelDuck = new ModelDuck();
modelDuck.Display();
modelDuck.Quack();
modelDuck.Fly();


WeatherData weatherData = new WeatherData();

ConditionsDisplay conditionsDisplay = new ConditionsDisplay(weatherData);
weatherData.MeasurementsChanged();
weatherData.NotifyObservers();