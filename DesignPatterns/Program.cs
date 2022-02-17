﻿using DesignPatterns.Abstract_Factory;
using DesignPatterns.Abstract_Factory.Factories;
using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Beverages;
using DesignPatterns.Decorator.Decorators;
using DesignPatterns.Factory_Method.Developers;
using DesignPatterns.Observer;
using DesignPatterns.Observer.Displays;
using DesignPatterns.Singleton;
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

Console.WriteLine("--------");

WeatherData weatherData = new WeatherData();

ConditionsDisplay conditionsDisplay = new ConditionsDisplay(weatherData);
weatherData.MeasurementsChanged();
weatherData.NotifyObservers();

Console.WriteLine("--------");

Beverage beverage = new Espresso();
Console.WriteLine(beverage.Name);
Console.WriteLine(beverage.Cost());

Beverage beverage2 = new HouseBlend();
beverage2 = new Mocha(new Milk(beverage2));
Console.WriteLine(beverage2.Name);
Console.WriteLine(beverage2.Cost());

Console.WriteLine("--------");

PizzaStore pizzaStore = new PizzaStore(new NYPizzaFactory());
pizzaStore.OrderPizza("cheese");

Console.WriteLine("--------");

Developer dev = new PanelDeveloper("Test1");
var house2 = dev.Create();

Console.WriteLine("--------");

ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
chocolateBoiler.Fill();
Console.WriteLine($"isEmpty: {chocolateBoiler.isEmpty} isBoiled: {chocolateBoiler.isBoiled}");
ChocolateBoiler chocolateBoiler2 = ChocolateBoiler.GetInstance();
Console.WriteLine($"isEmpty: {chocolateBoiler2.isEmpty} isBoiled: {chocolateBoiler2.isBoiled}");